// See https://aka.ms/new-console-template for more information
using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardManager;
using AntsFarm.Engine.Engine.Implementation;
using AntsFarm.Models.Utilities;

Console.WriteLine("Hello, World!");


BoardCreator boardCreator = new BoardCreator(new EntitySeeder());
AntBoardManager antBoardManager = new AntBoardManager(boardCreator);
antBoardManager.Init(20);

AntsEngine antsEngine = new AntsEngine(new AntsFarm.Engine.Mediator.Implementation.QueenMediator(), new AntsFarm.Engine.Factory.AntFactory(new AntsFarm.Engine.PathFinding.Implementations.AStarPathFinder(antBoardManager.GetBoard())), antBoardManager);
antsEngine.Start();