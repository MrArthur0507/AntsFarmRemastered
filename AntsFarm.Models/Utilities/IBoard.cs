using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public interface IBoard
    {
        public IPathFindable this[int index, int index2] { get; set; }

        public Point QueenPosition { get; set; }
        public List<Point> GrainPositions { get; set; }
        public int GetLength();
    }
}
