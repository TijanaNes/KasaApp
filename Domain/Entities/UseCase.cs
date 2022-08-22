using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UseCase : EntityBase
    {
        public int UseCaseIdentifier { get; set; }
        public string Name { get; set; }

        public List<Employee_UseCase> User_UseCases { get; set; }
    }
}
