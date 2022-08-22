using Application.Dto.EmployeeDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.EmployeeValidators
{
    public class ActivateEmployeeValidation : BaseValidator<ActivateEmployeeDto>
    {
        public ActivateEmployeeValidation(Context context) : base(context)
        {
            RuleFor(x => x.ActivationString).NotEmpty().WithMessage("Activation link is manditory");
            RuleFor(x => x.IdUser).NotEmpty().WithMessage("iduser is manditory").Must(x => context.Employees.Any(y => y.Id == x)).WithMessage("user not found");
        }
    }
}
