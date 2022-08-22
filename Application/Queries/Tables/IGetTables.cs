using Application.Core;
using Application.Dto.TablesDto;
using Application.Searches.TablesSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Tables
{
    public interface IGetTables : IQuery<TableSearch,IEnumerable<GetTablesDto>>
    {
    }
}
