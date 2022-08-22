using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.MenusDto
{
    public class MenuDto :DtoBase
    {
        public int IdMenu { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int IdSubType { get; set; }
        public string PictureSrc { get; set; }
    }
}
