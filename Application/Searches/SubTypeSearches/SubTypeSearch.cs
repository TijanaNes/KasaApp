using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Searches.SubTypeSearches
{
    public class SubTypeSearch : BaseSearch
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? IdType { get; set; }
    }
}
