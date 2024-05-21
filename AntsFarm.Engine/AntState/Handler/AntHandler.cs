using AntsFarm.Engine.AntState.Interfaces;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Models.Entities.Interfaces;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.AntState.Handler
{
    public class AntHandler : IAntHandler
    {
        public IAnt Ant { get; set; }
        public IAntState AntState { get; set; }
        public QueenMediator QueenMediator { get; set; }
        public IBoard board { get; set; }

        public AntHandler(IBoard board)
        {
            this.board = board;
        }
        public void MoveAnt(Point p)
        {
            AntState.Execute(this);
        }
    }
}
