using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerator.Interfaces
{
    public interface IEntitySeeder
    {
        public void SeedBoard(IBoard board, int maxGrainCount);
    }
}
