using Application.Core;
using Application.Dto;
using Application.Dto.LogReading;
using Application.Searches.LogSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Log
{
    public interface IGetAllLog : IQuery<LogSearch, PaginationReturn<GetAllLogDto>>
    {
    }
}
