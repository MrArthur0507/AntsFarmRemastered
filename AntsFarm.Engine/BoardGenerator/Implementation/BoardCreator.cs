﻿using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerator.Implementation
{
    public class BoardCreator
    {
        private readonly EntitySeeder seeder;
        public BoardCreator(EntitySeeder entitySeeder)
        {
            seeder = entitySeeder;
        }
        public IBoard GenerateBoard(int size)
        {
            IBoard board = new Board(size);
            seeder.SeedBoard(board);
            return board;
        }

    }
}
