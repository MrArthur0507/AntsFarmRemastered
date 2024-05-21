// See https://aka.ms/new-console-template for more information
using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Models.Utilities;

Console.WriteLine("Hello, World!");


BoardCreator boardCreator = new BoardCreator(new EntitySeeder());

IBoard board = boardCreator.GenerateBoard(20);

for (int i = 0; i < board.GetLength(); i++)
{
    for (int j = 0; j < board.GetLength(); j++)
    {
        Console.Write(board[i, j].Symbol);
    }
    Console.WriteLine();
}