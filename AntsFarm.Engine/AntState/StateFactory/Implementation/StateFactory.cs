using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.AntState.Implementations;
using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Engine.AntState.StateFactory.Interfaces;
using AntsFarm.Engine.PathFinding.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.StateFactory.Implementation
{
    public class StateFactory : IStateFactory
    {
        private readonly AStarPathFinder _pathFinder;

        public StateFactory(AStarPathFinder aStarPathFinder)
        {
            _pathFinder = aStarPathFinder;
        }
        public void GenerateState(IAntHandler ant, string state)
        {
            if (state == "travelingToQueen")
            {
                IAntState returnState = new TravelingToQueenState();
                returnState.CurrentCourse = _pathFinder.FindPath(ant.Ant.Location, _pathFinder.b.QueenPosition);
                ant.AntState = returnState;
            }
        }
    }
}
