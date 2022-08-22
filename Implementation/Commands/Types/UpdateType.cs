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
    public class UpdateType : IUpdateType
    {
        private readonly Context context;
        private readonly UpdateTypeValidator validator;

        public UpdateType(Context context, UpdateTypeValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 7;

        public string Name_UseCase => "Update type";

        public void Execute(UpdateTypeDto request)
        {
            this.validator.ValidateAndThrow(request);

            var toChange = this.context.Types.Find(request.IdToUpdate);
            toChange.Name = request.NewName;

            this.context.SaveChanges();

        }
    }
}
