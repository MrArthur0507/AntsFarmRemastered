using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.AntState.Implementations;
using AntsFarm.Engine.AntState.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.StateFactory.Interfaces
{
    public interface IStateFactory
    {
        public void GenerateState(IAntHandler ant, string state);
    }
}
