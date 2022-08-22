using Application.Dto.MenusDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.MenuValidator
{
    public class NewMenuValidator : BaseValidator<NewMenuDto>
    {
        public NewMenuValidator(Context context, ImageValidation imageValidator) : base(context)
        {
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price must not be empty").GreaterThan(0).WithMessage("Price must be greater than 0");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is manditory").Must(x => !context.Menus.Any(y => y.Name == x)).WithMessage("That name is already taken").MaximumLength(20).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").WithMessage("Name must begin with Capital letter");
            RuleFor(x => x.IdSubType).NotEmpty().WithMessage("Id subtype is manditory").Must(x => context.SubTypes.Any(y => y.Id == x)).WithMessage("provided Subtype not found");

            RuleFor(x => x.Picture).SetValidator(imageValidator);
        }
    }
}
