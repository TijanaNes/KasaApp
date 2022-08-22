using Application.Commands.Employees;
using Application.Core;
using Application.CustomExceptions;
using Application.Dto.EmployeeDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.EmployeeValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Employee
{
    public class ActivateUser : IActivateUser
    {
        private readonly Context context;
        private readonly ActivateEmployeeValidation validator;
        private readonly IPasswordEncryptor passwordEncryptor;

        public ActivateUser(Context context, ActivateEmployeeValidation validator, IPasswordEncryptor passwordEncryptor)
        {
            this.context = context;
            this.validator = validator;
            this.passwordEncryptor = passwordEncryptor;
        }

        public int Id_UseCase => 19;

        public string Name_UseCase => "Activating user";

        public void Execute(ActivateEmployeeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var ActivatingUser = this.context.Employees.Find(request.IdUser);

            if (ActivatingUser.Active)
            {
                throw new UserAlreadyActiveException("This user is already active");
            }

            ActivatingUser.Active = ActivatingUser.Password + this.passwordEncryptor.HashPassword(ActivatingUser.EmailAddress) == request.ActivationString;

            this.context.SaveChanges();

        }
    }
}
