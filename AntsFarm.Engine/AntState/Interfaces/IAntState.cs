using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Interfaces
{
    public interface IAntState
    {
        public List<Point> CurrentCourse { get; set; }
        public void Move(IAnt ant);
    }
}
