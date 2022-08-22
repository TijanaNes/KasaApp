using Application.Dto.MenusDto;
using Application.Dto.SubTypeDto;
using Application.Dto.TypesDto;
using Application.Queries.Types;
using Application.Searches.TypesSearches;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.Types
{
    public class GetType : IGetType
    {
        private readonly Context context;

        public GetType(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 8;

        public string Name_UseCase => "Get all the types";

        public IEnumerable<GetTypesDto> Query(TypesSearches search)
        {
            var query = this.context.Types.AsQueryable();

            if(search.IdType != null)
            {
                query = query.Where(x => x.Id == search.IdType);
            }
            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }

            return query.Select(x => new GetTypesDto()
            {
                IdType = x.Id,
                SubTypeList = x.SubTypes.Select(y => new GetSubTypeDto()
                {
                    Name = y.Name,
                    IdSubType = y.Id,
                    IdType = x.Id,
                    MenusFromSubType = y.Menus.Select(m => new MenuDto()
                    {
                        IdMenu = m.Id,
                        IdSubType = y.Id,
                        Name = m.Name,
                        PictureSrc = m.PictureSrc,
                        Price = m.Price
                    }).ToList()
                }).ToList(),
                TypeName = x.Name
            }).ToList();

        }
    }
}
