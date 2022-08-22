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
    public class RemoveSubTypeValidator : BaseValidator<RemoveSubTypeDto>
    {
        public RemoveSubTypeValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdToRemove).NotEmpty().WithMessage("Id is manditory").Must(x => context.SubTypes.Any(y => y.Id == x)).WithMessage("SubType not found").Must(x => !context.Menus.Any(y => y.SubTypeId == x)).WithMessage("This Subtype is used in menu table... you must delete it there first because of constraint");
        }
    }
}
