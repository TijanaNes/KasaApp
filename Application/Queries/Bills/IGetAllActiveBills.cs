using Application.Core;
using Application.Dto.BillsDto;
using Application.Searches.BillSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Bills
{
    public interface IGetAllActiveBills : IQuery<BillSearch,IEnumerable<GetActiveBillsDto>>
    {
    }
}