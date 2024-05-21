using AntsFarm.Models.Entities.Implementations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Implementations
{
    public class BaseQueen : PathFindableEntity
    {
        public BaseQueen()
        {
            Name = "Queen";
            Symbol = 'Q';
        }
    }
}
