using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Type : EntityBase
    {
        public string Name { get; set; }

        public List<SubType> SubTypes { get; set; }
    }
}
