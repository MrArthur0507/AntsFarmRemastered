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
    public class ReturningToBaseState : IAntState
    {
        public List<Point> CurrentCourse { get; set; }
        private int pos = 0;
        public void Execute(IAntHandler ant)
        {
            if (pos < CurrentCourse.Count)
            {
                ant.Ant.Energy--;
                ant.LastPos = ant.Ant.Location;
                ant.Ant.Location = CurrentCourse[pos];
                ant.QueenMediator.Notify(ant, "moved");
                pos++;

            }
            else
            {
                ant.QueenMediator.Notify(ant, "destroyed");
            }
        }
    }
}
