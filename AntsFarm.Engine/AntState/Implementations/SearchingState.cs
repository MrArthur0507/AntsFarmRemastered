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
    public class SearchingState : IAntState
    {
        public List<Point> CurrentCourse { get; set; }

        
        public SearchingState(List<Point> points) {
            CurrentCourse = points;
        }
        private int pos = 0;
        public void Execute(IAntHandler ant)
        {
            ant.MoveAnt(CurrentCourse[pos]);
            
        }
    }
}
