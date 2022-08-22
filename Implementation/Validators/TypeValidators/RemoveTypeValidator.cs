using Application.Commands.Types;
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
    public class RemoveTypeValidator : BaseValidator<RemoveTypeDto>
    {
        public RemoveTypeValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdToRemove).NotEmpty().WithMessage("Id is manditory").Must(x => context.Types.Any(y => y.Id == x)).WithMessage("Type not found").Must(x => !context.SubTypes.Any(y => y.TypeId == x)).WithMessage("This type is used in subtype table... you must delete it there first because of constraint");

        }
    }
}
