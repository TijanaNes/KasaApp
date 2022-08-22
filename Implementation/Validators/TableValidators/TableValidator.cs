using Application.Dto.TablesDto;
using DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Validators.TableValidators
{
    public class TableValidator : BaseValidator<RegisterNewTableDto>
    {
        public TableValidator(Context context) : base(context)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name must not be empty").Must(x => !context.Tables.Any(y => y.Name == x)).WithMessage("Name must be unique");
        }
    }
}
