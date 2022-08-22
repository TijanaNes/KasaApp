using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.TypesDto
{
    public class UpdateTypeDto: DtoBase
    {
        public int IdToUpdate { get; set; }
        public string NewName { get; set; }
    }
}
