using Application.Core;
using Application.Dto.TablesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Tables
{
    public interface IRegisterNewTable : ICommand<RegisterNewTableDto>
    {
    }
}
