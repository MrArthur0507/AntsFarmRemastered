using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerator.Interfaces
{
    public interface IEntityGenerator
    {
        public IPathFindable GenerateEntity();
    }
}
