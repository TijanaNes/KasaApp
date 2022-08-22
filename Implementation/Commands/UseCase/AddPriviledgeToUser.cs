using Application.Commands.UseCase;
using Application.Dto.UseCase;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.UseCaseValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.UseCase
{
    public class AddPriviledgeToUser : IAddPriviledgeToUser
    {
        private readonly Context context;
        private readonly AddPriviledgeToUserValidator validator;

        public AddPriviledgeToUser(Context context, AddPriviledgeToUserValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 20;

        public string Name_UseCase => "Adding priviledge to the user";

        public void Execute(AddPriviledgeToUserDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newPriviledge = new Employee_UseCase()
            {
                UseCaseId = request.IdUseCase,
                UserId = request.IdUser
            };

            this.context.Employee_UseCases.Add(newPriviledge);

            this.context.SaveChanges();

        }
    }
}
