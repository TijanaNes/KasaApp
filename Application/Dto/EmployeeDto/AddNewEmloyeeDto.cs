using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.EmployeeDto
{
    public class AddNewEmloyeeDto : DtoBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
