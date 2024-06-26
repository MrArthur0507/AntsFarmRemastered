﻿using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.BoardGenerator.Interfaces;
using AntsFarm.Engine.Observer;
using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Entities.Implementations.Base;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardManager
{
    public class AntBoardManager : IObserver
    {
        private  IBoard board;
        private readonly IBoardCreator boardCreator;

        public AntBoardManager(IBoardCreator boardCreator)
        {
            this.boardCreator = boardCreator;
        }
        public void Update(IAntHandler antHandler)
        {
            
            board[antHandler.Ant.Location.X, antHandler.Ant.Location.Y].Temp.Add(antHandler.Ant);
            board[antHandler.LastPos.X, antHandler.LastPos.Y].Temp.Remove(antHandler.Ant);
        }

        public void Init(int size)
        {
            board = boardCreator.GenerateBoard(size);
        }

        public IBoard GetBoard()
        {
            return board; 
        }

        public void Print()
        {
            for (int i = 0; i < board.GetLength(); i++)
            {
                for (int j = 0; j < board.GetLength(); j++)
                {
                    if (board[i, j].Temp.Count < 1)
                    {
                        Console.Write(board[i, j].BaseTile.Symbol);
                    } else
                    {
                        Console.Write("A"); 
                    }
                }
                Console.WriteLine();
            }
        }

        public void Update(IAntHandler antHandler, string ev)
        {
            Update(antHandler);
            if (ev == "found")
            {
                board[antHandler.Ant.Location.X, antHandler.Ant.Location.Y] = new Tile(new PathFindableEntity());
            } else if (ev == "destroyed")
            {
                board[antHandler.Ant.Location.X, antHandler.Ant.Location.Y].Temp.Remove(antHandler.Ant);
            }
        }
    }
}
