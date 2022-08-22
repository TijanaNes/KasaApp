using Application.Dto.SubTypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.TypesDto
{
    public class GetTypesDto :DtoBase
    {
        public int IdType { get; set; }
        public string TypeName { get; set; }
        public IEnumerable<GetSubTypeDto> SubTypeList { get; set; }
    }
}
