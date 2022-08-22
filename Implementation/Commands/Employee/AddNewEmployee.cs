using Application.Commands.Employees;
using Application.Core;
using Application.Dto.EmployeeDto;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.EmployeeValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Employees
{
    public class AddNewEmployee : IAddNewEmployee
    {
        private readonly Context context;
        private readonly AddNewEmployeeValidator validator;
        private readonly IPasswordEncryptor passwordEncryptor;
        private readonly IEmailSender emailSender;

        public AddNewEmployee(Context context, AddNewEmployeeValidator validator, IPasswordEncryptor passwordEncryptor, IEmailSender emailSender)
        {
            this.context = context;
            this.validator = validator;
            this.passwordEncryptor = passwordEncryptor;
            this.emailSender = emailSender;
        }

        public int Id_UseCase => 4;

        public string Name_UseCase => "Registering new employe to the system";

        public void Execute(AddNewEmloyeeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newId = this.context.Employees.OrderByDescending(y => y.Id).Select(x => x.Id).First() + 1;

            var encPassword = this.passwordEncryptor.HashPassword(request.Password);
            var encEmail = this.passwordEncryptor.HashPassword(request.EmailAddress);
            var activationLink = "http://localhost:5000/Api/Employee/ActivateAccount?ActivationStringy=" + encPassword + encEmail+ "&IdUser="+newId;

            var ListOfAdminIds = new List<int>() { 23,25,4,20,21,22};

            var getUseCases = this.context.UseCases.Where(x => !ListOfAdminIds.Contains(x.UseCaseIdentifier)).Select(x => new Employee_UseCase()
            {
                 UseCaseId = x.UseCaseIdentifier
            }).ToList();


            var newEmployee = new Domain.Entities.Employee()
            {
                UserName = request.Username,
                Password = encPassword,
                EmailAddress = request.EmailAddress,
                Name = request.Name,
                LastName = request.LastName,
                Active = false,
                User_UseCases = getUseCases
            };

            this.context.Add(newEmployee);
            this.context.SaveChanges();

            //Slanje imejla ne radi zbog promene google polise :(
            this.emailSender.SendEmail("Account activation", request.EmailAddress, "Hello we are sending this email in order to activate your account, kindly click the link : <a href='" + activationLink + "'> Link </a>");

        }
    }
}
