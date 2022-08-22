using Application.Commands.Menus;
using Application.Dto.MenusDto;
using DataAccess;
using FluentValidation;
using Implementation.Validators.MenuValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Menus
{
    public class RemoveMenu : IRemoveMenu
    {
        private readonly Context context;
        private readonly RemoveMenuValidator validator;

        public RemoveMenu(Context context, RemoveMenuValidator validator)
        {
            this.context = context;
            this.validator = validator;
        }

        public int Id_UseCase => 14;

        public string Name_UseCase => "Remove item from menu";

        public void Execute(RemoveMenuDto request)
        {
            this.validator.ValidateAndThrow(request);

            var menuToDelete = this.context.Menus.Find(request.IdToRemove);

            menuToDelete.Date_Deleted = DateTime.UtcNow;
            menuToDelete.IsDeleted = true;

            this.context.SaveChanges();
        }
    }
}
