using Application.Commands.SubTypes;
using Application.Dto.SubTypesDto;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.SubTypeValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.SubTypes
{
    public class NewSubType : INewSubType
    {
        private readonly Context context;
        private readonly NewSubTypeValidator validator;

        public NewSubType(Context context, NewSubTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 9;

        public string Name_UseCase => "Adding new subtype to the system";

        public void Execute(NewSubTypeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var newSubType = new SubType()
            {
                TypeId = request.TypeId,
                Name = request.Name
            };

            this.context.SubTypes.Add(newSubType);

            this.context.SaveChanges();

        }
    }
}
