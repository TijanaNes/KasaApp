using Application.Core;
using Application.Dto;
using Application.Dto.MenusDto;
using Application.Searches.MenuSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Menus
{
    public interface IGetmenus : IQuery<MenuSearch,PaginationReturn<MenuDto>>
    {
    }
}
