using AntsFarm.Engine.AntState.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Observer
{
    public interface IObserver
    {
        void Update(IAntHandler antHandler);
    }
}
