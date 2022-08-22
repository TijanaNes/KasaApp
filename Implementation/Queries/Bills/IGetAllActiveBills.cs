using Application.Dto.BillsDto;
using Application.Queries.Bills;
using Application.Searches.BillSearch;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.Bills
{
    public class GetAllActiveBills : IGetAllActiveBills
    {
        private readonly Context context;

        public GetAllActiveBills(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 26;

        public string Name_UseCase => "Get all active bills";

        public IEnumerable<GetActiveBillsDto> Query(BillSearch search)
        {
            var query = this.context.Tables.AsQueryable();

            if(search.IdTable != null && search.IdTable != 0)
            {
                query = query.Where(x => x.Id == search.IdTable);
            }


            return query.Select(x => new GetActiveBillsDto()
            {
                IdTable = x.Id,
                TableName = x.Name,
                WeiterName = x.Bills.Where(y => y.BillClosed == DateTime.MinValue).First().Weiter.Name + x.Bills.Where(y => y.BillClosed == DateTime.MinValue).First().Weiter.LastName,
                BillId = x.Bills.Where(y => y.BillClosed == DateTime.MinValue).First().Id,
                BoughtSoFar = x.Bills.Where(y => y.BillClosed == DateTime.MinValue).First().BillDetails.Select(m => new activeBillMenuInternal()
                {
                    AmountTaken = m.Amount,
                    IdMenu = m.Id,
                    NameMenu = m.Menu.Name
                }).ToList()
            });
        }
    }
}
 