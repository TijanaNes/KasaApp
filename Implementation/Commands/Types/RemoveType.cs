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
    public class RemoveType : IRemoveType
    {
        private readonly Context context;
        private readonly RemoveTypeValidator validator;

        public RemoveType(Context context, RemoveTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 6;

        public string Name_UseCase => "Removes the type from DB";

        public void Execute(RemoveTypeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var ToDelete = this.context.Types.Find(request.IdToRemove);

            ToDelete.IsDeleted = true;
            ToDelete.Date_Deleted = DateTime.UtcNow;

            this.context.SaveChanges();
        }
    }
}
