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
    public class AddUseCase : IAddUseCase
    {
        private readonly Context context;
        private readonly AddUseCaseValidator validator;

        public AddUseCase(Context context, AddUseCaseValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 21;

        public string Name_UseCase => "Adding new useCase";

        public void Execute(AddUseCaseDto request)
        {
            this.validator.ValidateAndThrow(request);

            var addUseCase = new Domain.Entities.UseCase()
            {
                Name = request.Name,
                UseCaseIdentifier = request.UsecaseIndentifier,
            };

            this.context.UseCases.Add(addUseCase);
            this.context.SaveChanges();
        }
    }
}
