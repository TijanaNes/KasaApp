using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bill : EntityBase
    {
        public int TableId { get; set; }
        public int WeiterId { get; set; }
        public DateTime BillOpened { get; set; }
        public DateTime BillClosed { get; set; }
        public decimal? FinalPrice { get; set; }

        public Table Table { get; set; }
        public Employee Weiter { get; set; }
        public List<BillDetails> BillDetails { get; set; }
    }
}
