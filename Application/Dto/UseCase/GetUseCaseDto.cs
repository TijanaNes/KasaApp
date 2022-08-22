using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.UseCase
{
    public class GetUseCaseDto : DtoBase
    {
        public int Id { get; set; }
        public int UseCaseIdentifier { get; set; }
        public string Name { get; set; }
    }
}
