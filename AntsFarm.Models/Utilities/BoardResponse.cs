using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Utilities
{
    public class BoardResponse
    {
        public IBoard Board { get; set; }

        public List<string> Messages { get; set; }
    }
}
