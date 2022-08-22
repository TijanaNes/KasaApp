using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.BillsDto
{
    public class AddBillDetailDto :DtoBase
    {
        public int IdBill { get; set; }
        public int IdMenu { get; set; }
        public int Amount { get; set; }
    }
}
