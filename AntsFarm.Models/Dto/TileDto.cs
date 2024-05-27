using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Dto
{
    public class TileDto
    {
        public bool HasAnt { get; set; }
        public bool HasGrain { get; set; }
        public bool HasObstacle { get; set; }
        public TileDto(bool hasAnt, bool hasGrain)
        {
            HasAnt = hasAnt;
            this.HasGrain = hasGrain;
        }
    }
}
