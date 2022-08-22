using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Searches.TablesSearches
{
    public class TableSearch : BaseSearch
    {
        public string? Name { get; set; }
        public int? Id { get; set; }
        public decimal? MoneyRangeMin { get; set; }
        public decimal? MoneyRangeMax { get; set; }
    }
}
