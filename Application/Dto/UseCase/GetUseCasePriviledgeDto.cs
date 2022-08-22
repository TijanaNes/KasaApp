using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.UseCase
{
    public class GetUseCasePriviledgeDto: DtoBase
    {
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public IEnumerable<useCaseInternal> UseCaseList { get; set; }
    }
    public class useCaseInternal : DtoBase
    {
        public string NameUseCase { get; set; }
        public int IdUseCase { get; set; }
        public int UseCaseIdentifier { get; set; }
    }
}
