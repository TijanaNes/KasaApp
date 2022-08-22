using Application.Core;
using Application.Dto.EmployeeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Employees
{
    public interface IAddNewEmployee : ICommand<AddNewEmloyeeDto>
    {
    }
}
