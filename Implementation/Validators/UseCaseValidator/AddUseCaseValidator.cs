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
    public class AddUseCaseValidator : BaseValidator<AddUseCaseDto>
    {
        public AddUseCaseValidator(Context context) : base(context)
        {
            RuleFor(x => x.UsecaseIndentifier).NotEmpty().WithMessage("UsecaseIndentifier is manditory").Must(x => !context.UseCases.Any(y => y.UseCaseIdentifier == x)).WithMessage("That UsecaseIndentifier already exist");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is manditory").Must(x => !context.UseCases.Any(y => y.Name == x)).WithMessage("That Name is taken");
        }
    }
}
