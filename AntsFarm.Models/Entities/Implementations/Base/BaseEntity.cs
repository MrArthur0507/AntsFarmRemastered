using AntsFarm.Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Models.Entities.Implementations.Base
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            Name = Guid.NewGuid().ToString();
            Symbol = '#';
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public char Symbol { get; set; }
    }
}
