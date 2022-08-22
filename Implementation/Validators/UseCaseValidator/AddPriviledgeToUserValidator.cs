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
    public class AddPriviledgeToUserValidator : BaseValidator<AddPriviledgeToUserDto>
    {
        public AddPriviledgeToUserValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdUser).NotEmpty().WithMessage("IdUser is manditory").Must(x => context.Employees.Any(y => y.Id == x)).WithMessage("User not found");
            RuleFor(x => x.IdUseCase).NotEmpty().WithMessage("Id useCase is manditory").Must(x => context.UseCases.Any(y => y.UseCaseIdentifier == x)).WithMessage("UseCase not found");
        }
    }
}
