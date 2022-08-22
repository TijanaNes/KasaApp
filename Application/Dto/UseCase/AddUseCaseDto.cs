using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.UseCase
{
    public class AddUseCaseDto :DtoBase
    {
        public string Name { get; set; }
        public int UsecaseIndentifier { get; set; }
    }
}
