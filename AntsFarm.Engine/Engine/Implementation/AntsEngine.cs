using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardManager;
using AntsFarm.Engine.Engine.Interfaces;
using AntsFarm.Engine.Factory;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Engine.Mediator.Interfaces;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Engine.Implementation
{
    public class AntsEngine : IEngine
    {
        private int antsCount;

        private readonly int grainsCount;

        private readonly int grainsMaxCount;

        private readonly IFarmMediator farmMediator;
        private readonly AntFactory antFactory;
        private readonly AntBoardManager antBoardManager;

        public AntsEngine(QueenMediator mediator, AntFactory factory, AntBoardManager antBoardManager)
        {
            farmMediator = mediator;
            antFactory = factory;
            this.antBoardManager = antBoardManager;
            Setup(20);
        }

        private void Setup(int size)
        {
            
            antBoardManager.Print();
            farmMediator.Observers.Add(antBoardManager);
        }

        public void Start()
        {
            while (true)
            {
                HandleMove();
                antBoardManager.Print();
                Thread.Sleep(1000);
            }
        }

        public IBoard HandleMove()
        {
            if (antsCount < 100)
            {
                farmMediator.RegisterAnt(antFactory.CreateAnt());
                antsCount++;
            }
            foreach (var antHandler in farmMediator.Ants)
            {
                antHandler.AntState.Execute(antHandler);
            }
            return antBoardManager.GetBoard();
        }
    }
}
