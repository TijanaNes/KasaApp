using Application.Dto.TablesDto;
using Application.Queries.Tables;
using Application.Searches.TablesSearches;
using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.Tables
{
    public class GetTables : IGetTables
    {
        public GetTables(Context context)
        {
            Context = context;
        }

        public Context Context { get; set; }

        public int Id_UseCase => 2;

        public string Name_UseCase => "Geting the tables";

        public IEnumerable<GetTablesDto> Query(TableSearch search)
        {
            var query = this.Context.Tables.AsQueryable();

            if (search.Id != null)
            {
                query = query.Where(x => x.Id == search.Id);
            }
            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }

            if (search.MoneyRangeMin != null)
            {
                query = query.Where(x =>  search.MoneyRangeMin <= x.Bills.Sum(y=>y.FinalPrice) );
            }
            if (search.MoneyRangeMax != null)
            {
                query = query.Where(x => search.MoneyRangeMax >= x.Bills.Sum(y => y.FinalPrice));
            }

            return query.Select(x => new GetTablesDto()
            {
                IdTable = x.Id,
                NameTable = x.Name,
                MoneyEarned = (decimal)x.Bills.Sum(x => x.FinalPrice),
                NumberOfBills = x.Bills.Where(y=>y.BillClosed != DateTime.MinValue).Count()
            });


        }
    }
}
