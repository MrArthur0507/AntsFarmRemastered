using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Implementations
{
    public class TravelingToGrainState : IAntState
    {
        public List<Point> CurrentCourse { get; set; }

        public void Move(IAnt ant)
        {
            
        }
    }
}
