using Application.Commands.Menus;
using Application.Core;
using Application.Dto.MenusDto;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.MenuValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Menus
{
    public class NewMenu : INewMenu
    {
        private readonly Context context;
        private readonly NewMenuValidator validator;
        private readonly IMovePicture pictureMover;

        public NewMenu(Context context, NewMenuValidator validator, IMovePicture pictureMover)
        {
            this.context = context;
            this.validator = validator;
            this.pictureMover = pictureMover;
        }

        public int Id_UseCase => 13;

        public string Name_UseCase => "Create new menu";

        public void Execute(NewMenuDto request)
        {
            this.validator.ValidateAndThrow(request);

            var pictureSrc = this.pictureMover.movePicture(request.Picture);

            var newMenu = new Menu()
            {
                Name = request.Name,
                Price = request.Price,
                SubTypeId = request.IdSubType,
                PictureSrc = pictureSrc
            };

            this.context.Menus.Add(newMenu);
            this.context.SaveChanges();
        }
    }
}
