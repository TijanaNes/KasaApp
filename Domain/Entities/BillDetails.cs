using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BillDetails : EntityBase
    {
        public int BillId { get; set; }
        public int MenuId { get; set; }
        public int Amount { get; set; }

        public Bill Bill { get; set; }
        public Menu Menu { get; set; }
    }
}
