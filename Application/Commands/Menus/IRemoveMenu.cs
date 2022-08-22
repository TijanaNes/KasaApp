using Application.Core;
using Application.Dto.MenusDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Menus
{
    public interface IRemoveMenu : ICommand<RemoveMenuDto>
    {
    }
}
