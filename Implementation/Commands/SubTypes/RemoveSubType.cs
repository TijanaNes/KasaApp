using Application.Commands.SubTypes;
using Application.Dto.SubTypesDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.SubTypeValidators;
using System;

namespace Implementation.Commands.SubTypes
{
    public class RemoveSubType : IRemoveSubType
    {

        private readonly Context context;
        private readonly RemoveSubTypeValidator validator;

        public RemoveSubType(Context context, RemoveSubTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 10;

        public string Name_UseCase => "Remove subtype from system";

        public void Execute(RemoveSubTypeDto request)
        {

            this.validator.ValidateAndThrow(request);

            var subTypeToDelete = this.context.SubTypes.Find(request.IdToRemove);

            subTypeToDelete.IsDeleted = true;
            subTypeToDelete.Date_Deleted = DateTime.UtcNow;

            this.context.SaveChanges();

        }
    }
}
