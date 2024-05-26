using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public class Tile : ITile
    {
        public Tile(IPathFindable pathFindable) { 
            BaseTile = pathFindable;
        }
        public IPathFindable BaseTile { get; set; }
        public List<IPathFindable> Temp { get; set; } =  new List<IPathFindable>();
    }
}
