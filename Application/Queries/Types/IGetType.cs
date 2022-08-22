using Application.Core;
using Application.Dto.TypesDto;
using Application.Searches.TypesSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Types
{
    public interface IGetType : IQuery<TypesSearches,IEnumerable<GetTypesDto>>
    {
    }
}
