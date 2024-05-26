using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.PathFinding.Interfaces
{
    public interface IPathFinder
    {
        public IBoard b { get; set; }
        public List<Point> FindPath(Point start, Point end);
    }
}
