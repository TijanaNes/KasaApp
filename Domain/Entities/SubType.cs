using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubType : EntityBase
    {
        public string Name { get; set; }
        public int TypeId { get; set; }

        public Type Type { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
