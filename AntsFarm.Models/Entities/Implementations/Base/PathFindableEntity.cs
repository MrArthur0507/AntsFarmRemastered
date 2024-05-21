using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Implementations.Base
{
    public class PathFindableEntity : BaseEntity, IPathFindable
    {
        public PathFindableEntity() {
            IsWalkable = true;
        }

        public bool IsWalkable { get; set; }

        public Point Location { get; set; }
    }
}
