using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardManager;
using AntsFarm.Engine.Engine.Interfaces;
using AntsFarm.Engine.Factory;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Engine.Mediator.Interfaces;
using AntsFarm.Engine.Observer;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Engine.Implementation
{
    public class AntsEngine : IEngine, IObserver
    {
        private int antsCount;

        private readonly int grainsCount;

        private readonly int grainsMaxCount;

        private readonly IFarmMediator farmMediator;
        private readonly AntFactory antFactory;
        private readonly AntBoardManager antBoardManager;
        private BoardResponse boardResponse = new BoardResponse();
        
        public List<string> Messages { get; set; } = new List<string>();
        public AntsEngine(QueenMediator mediator, AntFactory factory, AntBoardManager antBoardManager)
        {
            farmMediator = mediator;
            antFactory = factory;
            this.antBoardManager = antBoardManager;
            Setup(20);
            boardResponse.Board = antBoardManager.GetBoard();
            boardResponse.Messages = Messages;
        }

        private void Setup(int size)
        {
            
            antBoardManager.Print();
            farmMediator.Observers.Add(antBoardManager);
            farmMediator.Observers.Add(this);
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

        public BoardResponse HandleMove()
        {
            Messages.Clear();
            if (antsCount < 100)
            {
                farmMediator.RegisterAnt(antFactory.CreateAnt());
                antsCount++;
            }
            foreach (var antHandler in farmMediator.Ants)
            {
                antHandler.AntState.Execute(antHandler);
            }
            if (farmMediator.Ants.Count == 0)
            {
                return null;
            }
            return boardResponse;
            
        }

        public void Update(IAntHandler antHandler, string ev)
        {
            if (ev == "found")
            {
                Messages.Add($"{antHandler.Ant.Id} picked grain at position {antHandler.Ant.Location}");
            } else if (ev == "delivered")
            {
                Messages.Add($"{antHandler.Ant.Id} delivered grain to Queen! {antHandler.Ant.Energy} Energy left");
            } else if (ev == "destroyed")
            {
                Messages.Add($"{antHandler.Ant.Id} finished!");
            }
            
        }
    }
}
