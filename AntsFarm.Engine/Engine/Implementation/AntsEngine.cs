using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardManager;
using AntsFarm.Engine.Factory;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Engine.Implementation
{
    public class AntsEngine
    {
        private readonly int antsCount;

        private readonly int grainsCount;

        private readonly int grainsMaxCount;

        private readonly QueenMediator farmMediator;
        private readonly AntFactory antFactory;
        private readonly AntBoardManager antBoardManager;

        public AntsEngine(QueenMediator mediator, AntFactory factory, AntBoardManager antBoardManager)
        {
            farmMediator = mediator;
            antFactory = factory;
            this.antBoardManager = antBoardManager;
        }

        private void Setup(int size)
        {
            
            antBoardManager.Print();
            farmMediator.Observers.Add(antBoardManager);
        }

        public void Start()
        {
            Setup(20);
            while (true)
            {
                if (antsCount < 100)
                {
                    farmMediator.RegisterAnt(antFactory.CreateAnt());
                }
                foreach (var item in farmMediator.ants)
                {
                    item.AntState.Execute(item);

                }
                antBoardManager.Print();
                Thread.Sleep(1000);
            }
        }
    }
}
