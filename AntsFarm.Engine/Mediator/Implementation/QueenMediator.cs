using AntsFarm.Engine.AntState.Handler;
using AntsFarm.Engine.Mediator.Interfaces;
using AntsFarm.Engine.Observer;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Mediator.Implementation
{
    public class QueenMediator : IFarmMediator
    {
        public List<IAntHandler> Ants { get; set; } =  new List<IAntHandler>();
        public void RegisterAnt(IAntHandler ant)
        {
            Ants.Add(ant);
            ant.QueenMediator = this;
        }

        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Notify(IAntHandler sender, string ev)
        {
            
            foreach (var item in Observers)
            {
                item.Update(sender, ev);
            }

        }
    }
}
