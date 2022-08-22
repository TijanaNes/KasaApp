using Application.Dto.UseCase;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.UseCaseValidator
{
    public class RemovePriviledgeFromUserValidator : BaseValidator<RemovePriviledgeFromUser>
    {
        public RemovePriviledgeFromUserValidator(Context context) : base(context)
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is manditory").Must(x => context.Employee_UseCases.Any(y => y.Id == x)).WithMessage("Id not found");
        }
    }
}
