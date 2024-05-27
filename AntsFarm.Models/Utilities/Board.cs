using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public class Board : IBoard
    {

        public Board(int size) {
            _board = new ITile[size, size];
        }

        public ITile[,] _board { get; set; }

        public Point QueenPosition { get; set; }

        public List<Point> GrainPositions { get; set; } = new List<Point>();
        public ITile this[int index, int index2]
        {
            get
            {
                return _board[index, index2];
            }
            
            set { _board[index, index2] = value; }

        }

        public int GetLength()
        {
            return _board.GetLength(0);
        }
    }
}
