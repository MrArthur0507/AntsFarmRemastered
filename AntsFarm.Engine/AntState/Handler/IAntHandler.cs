using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Handler
{
    public interface IAntHandler
    {
        public IAnt Ant { get; set; }

        public IAntState AntState { get; set; }
    }
}
