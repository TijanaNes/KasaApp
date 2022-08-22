using Application.Commands.Menus;
using Application.Core;
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
    public class UpdateMenu : IUpdateMenu
    {
        private readonly Context context;
        private readonly UpdateMenuValidator validator;
        private readonly IMovePicture pictureMover;

        public UpdateMenu(Context context, UpdateMenuValidator validator, IMovePicture pictureMover)
        {
            this.context = context;
            this.validator = validator;
            this.pictureMover = pictureMover;
        }

        public int Id_UseCase => 15;

        public string Name_UseCase => "Update menu element";

        public void Execute(UpdateMenuDto request)
        {
            this.validator.ValidateAndThrow(request);

            var objToChange = this.context.Menus.Find(request.IdToUpdate);

            if (request.IdSubtype != null)
            {
                objToChange.SubTypeId = (int)request.IdSubtype;
            }
            if (request.Picture != null){

                this.pictureMover.destroyPicture(objToChange.PictureSrc);
               
                var newPicture = this.pictureMover.movePicture(request.Picture);

                objToChange.PictureSrc = newPicture;
            }

            if (request.Price != null)
            {
                objToChange.Price = (decimal)request.Price;
            }
            if (!String.IsNullOrEmpty(request.Name))
            {
                objToChange.Name = request.Name;
            }

            this.context.SaveChanges();
        }
    }
}
