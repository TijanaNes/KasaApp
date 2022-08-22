using Application.Dto.BillsDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.BillValidators
{
    public class AddBillDetailValidator : BaseValidator<AddBillDetailDto>
    {
        public AddBillDetailValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdMenu).NotEmpty().WithMessage("Id menu is manditory").Must(x => context.Menus.Any(y => y.Id == x)).WithMessage("Id menu not found");
            RuleFor(x => x.IdBill).NotEmpty().WithMessage("Id bill is manditory").Must(x => context.Bills.Any(y => y.Id == x)).WithMessage("Id bill is manditory");
        }
    }
}
