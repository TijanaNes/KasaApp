using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee_UseCase : EntityBase
    {
        public int UserId { get; set; }
        public int UseCaseId { get; set; }
        public Employee User { get; set; }
        public UseCase UseCase { get; set; }
    }
}
