using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public interface ITile
    {
        public IPathFindable BaseTile { get; set; }

        public List<IPathFindable> Temp { get; set; }
    }
}
