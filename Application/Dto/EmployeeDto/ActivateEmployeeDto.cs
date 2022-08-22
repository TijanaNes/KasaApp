using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.EmployeeDto
{
    public class ActivateEmployeeDto : DtoBase
    {
        public string ActivationString { get; set; }
        public int IdUser { get; set; }
    }
}
