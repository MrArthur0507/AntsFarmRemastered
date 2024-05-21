using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Mediator.Interfaces
{
    public interface IFarmMediator
    {
        public void AddAnt(IAntHandler ant);
    }
}
