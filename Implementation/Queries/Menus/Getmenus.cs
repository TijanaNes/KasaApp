using Application.Dto;
using Application.Dto.MenusDto;
using Application.Queries.Menus;
using Application.Searches.MenuSearches;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.Menus
{
    public class Getmenus : IGetmenus
    {
        private readonly Context context;

        public Getmenus(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 16;

        public string Name_UseCase => "Get menus";

        public PaginationReturn<MenuDto> Query(MenuSearch search)
        {
            var query = this.context.Menus.AsQueryable();

            if (search.Id != null)
            {
                query = query.Where(x => x.Id == search.Id);
            }
            if (search.IdSubType != null)
            {
                query = query.Where(x => x.SubTypeId == search.IdSubType);
            }
            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }
            if (search.PriceMin != null)
            {
                query = query.Where(x => x.Price >= search.PriceMin);
            }
            if (search.PriceMax != null)
            {
                query = query.Where(x => x.Price <= search.PriceMax);
            }

            return new PaginationReturn<MenuDto>()
            {
                CurrentPage = search.Page,
                PerPage = search.PerPage,
                TotalCount = query.Count(),
                Data = query.Skip((search.Page - 1) * search.PerPage).Take(search.PerPage).Select(x => new MenuDto()
                {
                    IdMenu = x.Id,
                    IdSubType = x.SubTypeId,
                    Name = x.Name,
                    PictureSrc = x.PictureSrc,
                    Price = x.Price
                }).ToList()
            };
        }
    }
}
