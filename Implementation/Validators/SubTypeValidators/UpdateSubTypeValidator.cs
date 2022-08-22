using Application.Dto.SubTypesDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.SubTypeValidators
{
    public class UpdateSubTypeValidator : BaseValidator<UpdateSubTypeDto>
    {
        public UpdateSubTypeValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdToUpdate).NotEmpty().WithMessage("Id Subtype to update is manditory").Must(x => context.SubTypes.Any(y => y.Id == x)).WithMessage("That type id does not exist");
            RuleFor(x => x.NewTypeId).Must(x => context.Types.Any(y => y.Id == x)).Unless(x => x == null).WithMessage("Type id not found");
            RuleFor(x => x.NewName).Must(x => !context.SubTypes.Any(y => y.Name == x)).Unless(x => !String.IsNullOrEmpty(x.NewName)).WithMessage("That name is already taken").MaximumLength(20).Unless(x => !String.IsNullOrEmpty(x.NewName)).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").Unless(x => !String.IsNullOrEmpty(x.NewName)).WithMessage("Name must begin with Capital letter");

        }
    }
}
