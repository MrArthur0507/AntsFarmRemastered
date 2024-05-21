using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Interfaces
{
    public interface IAnt : IPathFindable
    {
        public decimal Energy { get; set; }
    }
}
