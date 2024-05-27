using AntsFarm.Models.Entities.Implementations.Base;
using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Implementations
{
    public class BaseAnt : PathFindableEntity, IAnt
    {
        public decimal Energy { get; set; }

        public BaseAnt()
        {
            Symbol = 'A';
            Energy = 100;
        }
    }
}
