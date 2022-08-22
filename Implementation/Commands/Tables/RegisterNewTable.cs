using Application.Commands.Tables;
using Application.Dto.TablesDto;
using DataAccess;
using Domain.Entities;
using FluentValidation;
using Implementation.Validators.TableValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Tables
{
    public class RegisterNewTable : IRegisterNewTable
    {

        public TableValidator Validator { get; set; }
        public Context Context { get; set; }

        public int Id_UseCase => 1;

        public string Name_UseCase => "Registering new table to DB";
        
        public RegisterNewTable(TableValidator validator, Context context)
        {
            Validator = validator;
            Context = context;
        }

        public void Execute(RegisterNewTableDto request)
        {
            this.Validator.ValidateAndThrow(request);

            var newTable = new Table()
            {
                Name = request.Name
            };

            this.Context.Tables.Add(newTable);

            this.Context.SaveChanges();
        }
    }
}
