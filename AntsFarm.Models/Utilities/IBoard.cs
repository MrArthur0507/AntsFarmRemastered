using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public interface IBoard
    {
        public IPathFindable this[int index, int index2] { get; set; }

        public int GetLength();
    }
}
