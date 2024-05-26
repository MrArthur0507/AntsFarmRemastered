using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Handler
{
    public interface IAntHandler
    {
        public IAnt Ant { get; set; }
        public QueenMediator QueenMediator { get; set; }
        public IAntState AntState { get; set; }

        public Point LastPos { get; set; }
    }
}
