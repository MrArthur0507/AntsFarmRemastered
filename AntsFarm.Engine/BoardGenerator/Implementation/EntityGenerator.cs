using AntsFarm.Models.Entities.Implementations.Base;
using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntsFarm.Engine.BoardGenerator.Interfaces;

namespace AntsFarm.Engine.BoardGenerator.Implementation
{
    public class EntityGenerator : IEntityGenerator
    {
        private readonly Random random;
        public EntityGenerator()
        {
            random = new Random();
        }

        public IPathFindable GenerateEntity()
        {
            int r = random.Next(0, 11);
            if (r >= 0 && r <= 7)
            {
                return new PathFindableEntity();
            } else
            {
                return new Obstacle();
            }
            
            
        }
    }
}
