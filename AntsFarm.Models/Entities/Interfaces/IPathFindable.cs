using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Interfaces
{
    public interface IPathFindable : IBaseEntity
    {
        bool IsWalkable { get; }
        Point Location { get; set; }
    }
}
