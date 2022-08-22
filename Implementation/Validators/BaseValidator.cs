using Application.Dto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators
{
    public class BaseValidator<Dto> : AbstractValidator<Dto>
    {
        protected readonly Context context;

        public BaseValidator(Context context)
        {
            this.context = context;
        }
    }
}
