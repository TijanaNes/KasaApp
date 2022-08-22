using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.UseCase
{
    public class AddPriviledgeToUserDto :DtoBase
    {
        public int IdUser { get; set; }
        public int IdUseCase { get; set; }
    }
}
