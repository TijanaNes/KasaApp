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
    public class CloseBillValidator : BaseValidator<CloseBillDto>
    {
        public CloseBillValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdBillToClose).NotEmpty().WithMessage("Id is manditory").Must(x => context.Bills.Any(y => y.Id == x)).WithMessage("Bill not found");
        }
    }
}
