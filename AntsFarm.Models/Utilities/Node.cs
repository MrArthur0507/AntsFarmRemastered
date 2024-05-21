using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public class Node
    {
        public Point Position { get; }
        public int CostG { get; set; }
        public int CostH { get; set; }
        public int CostF => CostG + CostH;
        public Node Parent { get; set; }

        public Node(Point position)
        {
            Position = position;
        }
    }
}
