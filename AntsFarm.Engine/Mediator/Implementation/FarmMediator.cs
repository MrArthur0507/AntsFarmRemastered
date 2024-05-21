using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.Mediator.Interfaces;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Mediator.Implementation
{
    public class FarmMediator : IFarmMediator
    {
        private List<IAntHandler> ants = new List<IAntHandler>();
        public void AddAnt(IAntHandler ant)
        {
            ants.Add(ant);
        }
    }
}
