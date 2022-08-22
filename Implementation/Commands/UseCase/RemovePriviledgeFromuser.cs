using Application.Commands.UseCase;
using Application.Dto.UseCase;
using DataAccess;
using FluentValidation;
using Implementation.Validators.UseCaseValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.UseCase
{
    public class RemovePriviledgeFromuser : IRemovePriviledgeFromuser
    {
        private readonly Context context;
        private readonly RemovePriviledgeFromUserValidator validator;

        public RemovePriviledgeFromuser(Context context, RemovePriviledgeFromUserValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 22;

        public string Name_UseCase => "Removes the priviledge from user";

        public void Execute(RemovePriviledgeFromUser request)
        {
            this.validator.ValidateAndThrow(request);

            var objToRemove = this.context.Employee_UseCases.Find(request.Id);

            objToRemove.IsDeleted = true;
            objToRemove.Date_Deleted = DateTime.UtcNow;

            this.context.SaveChanges();
        }
    }
}
