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
    public class AddNewEmployeeValidator : BaseValidator<AddNewEmloyeeDto>
    {
        public AddNewEmployeeValidator(Context context) : base(context)
        {

            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address must not be empty").Must(x => !context.Employees.Any(y => y.EmailAddress == x)).WithMessage("Email address is already taken").EmailAddress().WithMessage("Email address is not valid");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username must not be empty").Must(x => !context.Employees.Any(y => y.UserName == x)).WithMessage("Username is already taken").MaximumLength(20).WithMessage("Maximum length is 20 characters");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name must not be empty").MaximumLength(20).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").WithMessage("Name must begin with Capital letter");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name must not be empty").MaximumLength(20).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").WithMessage("Last name must begin with Capital letter");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password must not be empty").MaximumLength(30).WithMessage("Maximum length is 30 characters").MinimumLength(5).WithMessage("Minimum length is 5 characters").Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,30}$").WithMessage("Password need atleast 1 uppercase letter, 1 lowercase letter and one number");


        }
    }
}
