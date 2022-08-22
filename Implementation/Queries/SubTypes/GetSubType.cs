using Application.Dto.MenusDto;
using Application.Dto.SubTypeDto;
using Application.Queries.SubTypes;
using Application.Searches.SubTypeSearches;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.SubTypes
{
    public class GetSubType : IGetSubType
    {
        private readonly Context context;

        public GetSubType(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 12;

        public string Name_UseCase => "Get the sub types";

        public IEnumerable<GetSubTypeDto> Query(SubTypeSearch search)
        {
            var query = this.context.SubTypes.AsQueryable();
            

            if(search.Id != null)
            {
                query = query.Where(x => x.Id == search.Id);
            }
            if(search.IdType !=null)
            {
                query = query.Where(x => x.TypeId == search.IdType);
            }
            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }

            return query.Select(x => new GetSubTypeDto()
            {
                Name = x.Name,
                IdType = x.TypeId,
                IdSubType = x.Id,
                MenusFromSubType = x.Menus.Select(y => new MenuDto()
                {
                    IdMenu = y.Id,
                    IdSubType = x.Id,
                    Name = y.Name,
                    PictureSrc = y.PictureSrc,
                    Price = y.Price
                }).ToList()
            }).ToList();

        }
    }
}
