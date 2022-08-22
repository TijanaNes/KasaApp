using Application.Dto.MenusDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.SubTypeDto
{
    public class GetSubTypeDto : DtoBase
    {
        public string Name { get; set; }
        public int IdSubType { get; set; }
        public int IdType { get; set; }
        public IEnumerable<MenuDto> MenusFromSubType { get; set; }
    }
}
