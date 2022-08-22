using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.SubTypesDto
{
    public class UpdateSubTypeDto: DtoBase
    {
        public int IdToUpdate { get; set; }
        public string? NewName { get; set; }
        public int? NewTypeId { get; set; }
    }
}
