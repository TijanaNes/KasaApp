using Application.Dto.TypesDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.TypeValidators
{
    public class UpdateTypeValidator : BaseValidator<UpdateTypeDto>
    {
        public UpdateTypeValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdToUpdate).NotEmpty().WithMessage("Id type to update is manditory").Must(x => context.Types.Any(y => y.Id == x)).WithMessage("That type id does not exist");
            RuleFor(x=>x.NewName).NotEmpty().WithMessage("Name is manditory").Must(x => !context.Types.Any(y => y.Name == x)).WithMessage("That name is already taken").MaximumLength(20).WithMessage("Maximum length is 20 characters").Matches(@"^[A-Z][a-z]{1,19}$").WithMessage("Name must begin with Capital letter");
        }
    }
}
