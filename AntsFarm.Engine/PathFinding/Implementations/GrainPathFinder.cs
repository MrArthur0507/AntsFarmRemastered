using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.PathFinding.Implementations
{
    public class GrainPathFinder
    {
        private readonly AStarPathFinder _pathFinder;
        private readonly IBoard board;
        private Point LastVisited = new Point(0, 0);
        public GrainPathFinder(AStarPathFinder aStarPathFinder, IBoard board)
        {
            _pathFinder = aStarPathFinder;
            this.board = board;
        }


        public List<Point> FindPathToGrain()
        {
            return _pathFinder.FindPath(new Point(0, 0), GetGrainPosition());
        }

        public Point GetGrainPosition()
        {
            for (int i = LastVisited.X; i < board.GetLength(); i++)
            {
                for (int j = LastVisited.Y; j < board.GetLength(); j++)
                {
                    if (board[i, j].GetType() == typeof(Grain))
                    {
                        LastVisited = new Point(i, j);
                        return LastVisited;
                    }
                }
            }
            return new Point();
        }
    }
}
