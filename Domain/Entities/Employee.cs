using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : EntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool Active { get; set; }
        public List<Employee_UseCase> User_UseCases { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
