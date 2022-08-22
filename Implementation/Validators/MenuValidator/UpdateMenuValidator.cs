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
    public class UpdateMenuValidator : BaseValidator<UpdateMenuDto>
    {
        public UpdateMenuValidator(Context context, ImageValidation imageValidator) : base(context)
        {
            RuleFor(x => x.Price).GreaterThan(0).Unless(x => x == null).WithMessage("Price must be greater than 0");
            RuleFor(x => x.Name).Must(x => !context.Menus.Any(y => y.Name == x)).Unless(x => !String.IsNullOrEmpty(x.Name)).WithMessage("That name is already taken").MaximumLength(20).Unless(x => !String.IsNullOrEmpty(x.Name)).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").Unless(x => !String.IsNullOrEmpty(x.Name)).WithMessage("Name must begin with Capital letter");
            RuleFor(x => x.IdSubtype).Must(x => context.SubTypes.Any(y => y.Id == x)).Unless(x => x == null).WithMessage("provided Subtype not found");
            RuleFor(x => x.Picture).SetValidator(imageValidator).Unless(x => x == null);
        }
    }
}
