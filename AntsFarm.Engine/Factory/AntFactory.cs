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
        private int grainCount = 0;
        public AntFactory(AStarPathFinder finder)
        {
            _pathFinder = finder;
           
        }
        public IAntHandler CreateAnt()
        {
            AntHandler handler = new AntHandler();
            handler.Ant = new BaseAnt();
            handler.AntState = new SearchingState(_pathFinder.FindPath(new System.Drawing.Point(0, 0), _pathFinder.b.GrainPositions[grainCount]));
            grainCount++;
            return handler;
        }
    }
}
