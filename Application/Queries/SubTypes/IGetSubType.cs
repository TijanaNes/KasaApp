using Application.Core;
using Application.Dto.SubTypeDto;
using Application.Searches.SubTypeSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.SubTypes
{
    public interface IGetSubType : IQuery<SubTypeSearch, IEnumerable<GetSubTypeDto>>
    {
    }
}
