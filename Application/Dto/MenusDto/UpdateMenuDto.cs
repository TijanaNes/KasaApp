using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.MenusDto
{
    public class UpdateMenuDto: DtoBase
    {
        public int IdToUpdate { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? IdSubtype { get; set; }
        public IFormFile? Picture { get; set; }
    }
}
