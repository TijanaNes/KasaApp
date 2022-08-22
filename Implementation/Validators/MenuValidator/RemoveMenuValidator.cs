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
    public class RemoveMenuValidator : BaseValidator<RemoveMenuDto>
    {
        public RemoveMenuValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdToRemove).NotEmpty().WithMessage("Id is manditory").Must(x => context.Menus.Any(y => y.Id == x)).WithMessage("Menu item not found").Must(x => !context.BillDetailss.Any(y => y.MenuId == x)).WithMessage("This Menu is used in bill detail table... you must delete it there first because of constraint");
        }
    }
}
