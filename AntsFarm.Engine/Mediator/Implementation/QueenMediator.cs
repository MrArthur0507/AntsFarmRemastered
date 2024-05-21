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
    public class QueenMediator : IFarmMediator
    {
        public List<IAntHandler> ants = new List<IAntHandler>();
        public void RegisterAnt(IAntHandler ant)
        {
            ants.Add(ant);
        }

        public void Notify(IAntHandler sender, string ev)
        {
            if (ev == "FoodFound")
            {
                Console.WriteLine("Grain found");
            }
            
        }
    }
}
