using Application.Commands.Bills;
using Application.Dto.BillsDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.BillValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Bills
{
    public class CloseBill : ICloseBill
    {
        private readonly Context context;
        private readonly CloseBillValidator validator;

        public CloseBill(Context context, CloseBillValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 18;

        public string Name_UseCase => "Close the bill";

        public void Execute(CloseBillDto request)
        {
            this.validator.ValidateAndThrow(request);

            var billToClose = this.context.Bills.Find(request.IdBillToClose);


            billToClose.FinalPrice  = this.context.BillDetailss.Where(x=>x.BillId == billToClose.Id).Sum(y => y.Amount * y.Menu.Price);
            billToClose.BillClosed = DateTime.UtcNow;

            var tableToReActivate = this.context.Tables.Find(billToClose.TableId);

            tableToReActivate.IsActive = false;

            this.context.SaveChanges();
        }
    }
}
