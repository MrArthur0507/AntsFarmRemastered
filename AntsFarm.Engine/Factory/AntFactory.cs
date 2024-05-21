using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.AntState.Implementations;
using AntsFarm.Engine.PathFinding.Implementations;
using AntsFarm.Engine.PathFinding.Interfaces;
using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Factory
{
    public class AntFactory : IAntFactory
    {
        private readonly AStarPathFinder _pathFinder;
        private readonly IBoard board;
        private int grainCount = 0;
        public AntFactory(AStarPathFinder finder, IBoard board)
        {
            _pathFinder = finder;
            this.board = board;
        }
        public IAntHandler CreateAnt()
        {
            AntHandler handler = new AntHandler(board);
            handler.Ant = new BaseAnt();
            handler.AntState = new SearchingState(_pathFinder.FindPath(new System.Drawing.Point(0, 0), board.GrainPositions[grainCount]));
            return handler;
        }
    }
}
