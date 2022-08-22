using Application.Commands.SubTypes;
using Application.CustomExceptions;
using Application.Dto.SubTypesDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.SubTypeValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.SubTypes
{
    public class UpdateSubType : IUpdateSubType
    {
        private readonly Context context;
        private readonly UpdateSubTypeValidator validator;

        public UpdateSubType(Context context, UpdateSubTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 11;

        public string Name_UseCase => "Update subtype";

        public void Execute(UpdateSubTypeDto request)
        {
            this.validator.ValidateAndThrow(request);

            if(request.NewTypeId == null && String.IsNullOrEmpty(request.NewName))
            {
                throw new EmptyRequestException("Type id, and New name are empty");
            }

            var objectToChange = this.context.SubTypes.Find(request.IdToUpdate);

            if(request.NewTypeId != null)
            {
                objectToChange.TypeId = (int)request.NewTypeId;
            }
            if (!String.IsNullOrEmpty(request.NewName))
            {
                objectToChange.Name = request.NewName;
            }

            this.context.SaveChanges();
        }
    }
}
