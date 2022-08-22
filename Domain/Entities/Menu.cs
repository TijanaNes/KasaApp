using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SubTypeId { get; set; }
        public string PictureSrc { get; set; }
        
        public SubType SubType { get; set; }
        public List<BillDetails> BillDetails { get; set; }

    }
}
