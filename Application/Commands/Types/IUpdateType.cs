using Application.Core;
using Application.Dto.TypesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Types
{
    public interface IUpdateType :ICommand<UpdateTypeDto>
    {
    }
}
