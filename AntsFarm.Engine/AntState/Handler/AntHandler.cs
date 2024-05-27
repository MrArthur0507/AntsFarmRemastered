using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Engine.AntState.StateFactory.Interfaces;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Engine.Observer;
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
    public class AntHandler : IAntHandler
    {
        public IAnt Ant { get; set; }
        public IAntState AntState { get; set; }
        public QueenMediator QueenMediator { get; set; }
        public IStateFactory StateFactory { get; set; }
        public Point LastPos { get; set; }

    }
}
