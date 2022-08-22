using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.LogReading
{
    public class GetAllLogDto :DtoBase
    {
        public string IdUsecase { get; set; }
        public string NameUseCase { get; set; }
        public string WhenDone { get; set; }
    }
}
