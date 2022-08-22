using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.BillsDto
{
    public class GetActiveBillsDto : DtoBase
    {
        public int IdTable { get; set; }
        public string TableName { get; set; }
        public string WeiterName { get; set; }
        public int? BillId { get; set; } = -1;
        public IEnumerable<activeBillMenuInternal> BoughtSoFar { get; set; }
    }
    public class activeBillMenuInternal: DtoBase
    {
        public int IdMenu { get; set; }
        public string NameMenu { get; set; }
        public int AmountTaken { get; set; }
    }
}
