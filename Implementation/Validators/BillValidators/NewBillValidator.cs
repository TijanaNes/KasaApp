using Application.Dto.BillsDto;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Implementation.Validators.BillValidators
{
    public class NewBillValidator : BaseValidator<CreateNewBillDto>
    {
        public NewBillValidator(Context context) : base(context)
        {
            RuleFor(x => x.IdWaiter).NotEmpty().WithMessage("Waiter id is manditory").Must(x => context.Employees.Any(y => y.Id == x)).WithMessage("Waiter id not found");
            RuleFor(x => x.IdTable).NotNull().WithMessage("Id table is manditory").Must(x => context.Tables.Any(y => y.Id == x)).WithMessage("Table id not found").Must(x =>
            {
                if(x != null)
                {
                    var selectedTable = context.Tables.Find(x);
                    return !selectedTable.IsActive;
                }
                return false;
            }).WithMessage("Selected table is already active");
        }
    }
}
