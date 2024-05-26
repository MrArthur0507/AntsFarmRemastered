using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.AntState.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Implementations
{
    public class TravelingToQueenState : IAntState
    {
        public List<Point> CurrentCourse { get; set; }

        public void Execute(IAntHandler ant)
        {
            ant.QueenMediator.Notify(ant, "Traveling to ant");
        }
    }
}
