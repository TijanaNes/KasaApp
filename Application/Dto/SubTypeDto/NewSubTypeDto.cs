using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.SubTypesDto
{
    public class NewSubTypeDto :DtoBase
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
    }
}
