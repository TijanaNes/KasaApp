using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.TablesDto
{
    public class GetTablesDto : DtoBase
    {
        public int IdTable { get; set; }
        public string NameTable { get; set; }
        public decimal MoneyEarned { get; set; }
        public int NumberOfBills { get; set; }

    }
}
