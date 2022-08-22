using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Table : EntityBase
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
        public List<Bill> Bills { get; set; }
    }
}
