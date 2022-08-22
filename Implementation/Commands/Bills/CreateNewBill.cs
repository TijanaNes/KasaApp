using Application.Commands.Bills;
using Application.Dto.BillsDto;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.BillValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Bills
{
    public class CreateNewBill : ICreateNewBill
    {
        private readonly Context context;
        private readonly NewBillValidator validator;

        public CreateNewBill(Context context, NewBillValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 3;

        public string Name_UseCase => "Create new Bill";

        public void Execute(CreateNewBillDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newBill = new Bill()
            {
                BillOpened = DateTime.UtcNow,
                WeiterId = request.IdWaiter,
                TableId = request.IdTable
            };

            var TableSetToActive = this.context.Tables.Find(request.IdTable);

            TableSetToActive.IsActive = true;

            this.context.Bills.Add(newBill);

            this.context.SaveChanges();

        }
    }
}
