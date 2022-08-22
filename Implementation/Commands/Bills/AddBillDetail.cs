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
    public class AddBillDetail : IAddBillDetail
    {
        private readonly Context context;
        private readonly AddBillDetailValidator validator;

        public AddBillDetail(Context context, AddBillDetailValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 17;

        public string Name_UseCase => "Add bill details to existing bill";

        public void Execute(AddBillDetailDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newBillDetail = new BillDetails()
            {
                Amount = request.Amount,
                MenuId = request.IdMenu,
                BillId = request.IdBill
            };

            this.context.BillDetailss.Add(newBillDetail);

            this.context.SaveChanges();
        }
    }
}
