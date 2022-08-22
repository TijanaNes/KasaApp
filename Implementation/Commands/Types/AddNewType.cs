using Application.Commands.Types;
using Application.Dto.TypesDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.TypeValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Types
{
    public class AddNewType : IAddNewType
    {
        private readonly Context context;
        private readonly NewTypeValidator validator;

        public AddNewType(Context context, NewTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 5;

        public string Name_UseCase => "Add new type";

        public void Execute(NewTypeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newType = new Domain.Entities.Type()
            {
                Name = request.Name
            };

            this.context.Types.Add(newType);
            this.context.SaveChanges();
        }
    }
}
