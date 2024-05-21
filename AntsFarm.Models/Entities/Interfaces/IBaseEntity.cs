using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Interfaces
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public char Symbol { get; set; }

    }
}
