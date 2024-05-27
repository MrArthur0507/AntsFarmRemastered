using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Engine.Interfaces
{
    public interface IEngine
    {
        public void Start();

        public IBoard HandleMove();
    }
}
