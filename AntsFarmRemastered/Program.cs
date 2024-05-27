// See https://aka.ms/new-console-template for more information
using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardManager;
using AntsFarm.Engine.Engine.Implementation;
using AntsFarm.Engine.Factory;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Models.Utilities;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using System.Text;
using WebSocketSharp.Server;
using System.Drawing;
using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Dto;

Console.WriteLine("Hello, World!");


//BoardCreator boardCreator = new BoardCreator(new EntitySeeder(new EntityGenerator()));
//AntBoardManager antBoardManager = new AntBoardManager(boardCreator);
//antBoardManager.Init(20);

//AntsEngine antsEngine = new AntsEngine(new AntsFarm.Engine.Mediator.Implementation.QueenMediator(), new AntsFarm.Engine.Factory.AntFactory(new AntsFarm.Engine.PathFinding.Implementations.AStarPathFinder(antBoardManager.GetBoard())), antBoardManager);
//antsEngine.Start();



var webSocketServer = new WebSocketServer("ws://localhost:13000");
webSocketServer.AddWebSocketService<BoardBehavior>("/Board");
webSocketServer.Start();

Console.WriteLine("WebSocket server started at ws://localhost:13000");
Console.ReadLine();
webSocketServer.Stop();

public class BoardBehavior : WebSocketBehavior
{
    private readonly AntsEngine engine;
    private Timer timer;

    public BoardBehavior()
    {
        var boardCreator = new BoardCreator(new EntitySeeder(new EntityGenerator()));
        var antBoardManager = new AntBoardManager(boardCreator);
        antBoardManager.Init(20);

        var mediator = new QueenMediator();
        var factory = new AntFactory(new AntsFarm.Engine.PathFinding.Implementations.AStarPathFinder(antBoardManager.GetBoard()));
        engine = new AntsEngine(mediator, factory, antBoardManager);
    }

    protected override void OnOpen()
    {
        timer = new Timer(SendBoardState, null, 0, 500); 
    }

    protected override void OnClose(WebSocketSharp.CloseEventArgs e)
    {
        timer.Dispose();
    }

    private void SendBoardState(object state)
    {
        Board board = (Board)engine.HandleMove().Board;
        string json = JsonSerializer.Serialize(MapToDto(board, engine.HandleMove().Messages));
        Console.WriteLine("Sending JSON: " + json); 
        Send(json);
    }

    private BoardDto MapToDto(IBoard board, List<string> msg)
    {
        var boardDto = new BoardDto
        {
            QueenPosition = board.QueenPosition,
            GrainPositions = board.GrainPositions,
            Tiles = new List<List<TileDto>>()
        };

        for (int i = 0; i < board.GetLength(); i++)
        {
            boardDto.Messages = msg;
            var row = new List<TileDto>();
            for (int j = 0; j < board.GetLength(); j++)
            {
                var tile = board[i, j];
                
                var tileDto = new TileDto(tile != null && tile.Temp.Count > 0, tile.BaseTile.GetType() == typeof(Grain));
                if (tile.BaseTile.GetType() == typeof(Obstacle))
                {
                    tileDto.HasObstacle = true;
                }
                row.Add(tileDto);
            }
            boardDto.Tiles.Add(row);
        }

        return boardDto;
    }
}

public class BoardDto
{
    public Point QueenPosition { get; set; }
    public List<Point> GrainPositions { get; set; }
    public List<List<TileDto>> Tiles { get; set; }

    public List<string> Messages { get; set; }
}




