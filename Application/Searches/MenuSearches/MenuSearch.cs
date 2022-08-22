using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Searches.MenuSearches
{
    public class MenuSearch : PaginationSearch
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? IdSubType { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
    }
}
