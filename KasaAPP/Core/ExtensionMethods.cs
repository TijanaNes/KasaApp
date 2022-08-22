using Application.Commands.Bills;
using Application.Commands.Employees;
using Application.Commands.Menus;
using Application.Commands.SubTypes;
using Application.Commands.Tables;
using Application.Commands.Types;
using Application.Commands.UseCase;
using Application.Core;
using Application.Queries.Bills;
using Application.Queries.Log;
using Application.Queries.Menus;
using Application.Queries.SubTypes;
using Application.Queries.Tables;
using Application.Queries.Types;
using Application.Queries.UseCase;
using Implementation.Commands.Bills;
using Implementation.Commands.Employee;
using Implementation.Commands.Employees;
using Implementation.Commands.Menus;
using Implementation.Commands.SubTypes;
using Implementation.Commands.Tables;
using Implementation.Commands.Types;
using Implementation.Commands.UseCase;
using Implementation.Queries.Bills;
using Implementation.Queries.Log;
using Implementation.Queries.Menus;
using Implementation.Queries.SubTypes;
using Implementation.Queries.Tables;
using Implementation.Queries.Types;
using Implementation.Queries.UseCases;
using Implementation.Validators;
using Implementation.Validators.BillValidators;
using Implementation.Validators.EmployeeValidators;
using Implementation.Validators.MenuValidator;
using Implementation.Validators.SubTypeValidators;
using Implementation.Validators.TableValidators;
using Implementation.Validators.TypeValidators;
using Implementation.Validators.UseCaseValidator;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KasaAPP.Core
{
    public static class ExtensionMethods
    {
        public static void AddQueriesUseCases(this IServiceCollection services)
        {
            services.AddTransient<IGetTables, GetTables>();//2
            services.AddTransient<IGetAllLog, GetAllLog>();//25
            services.AddTransient<IGetmenus, Getmenus>();//16
            services.AddTransient<IGetSubType, GetSubType>();//12
            services.AddTransient<IGetType, GetType>();//8
            services.AddTransient<IGetUseCase, GetUseCase>();//23
            services.AddTransient<IGetUseCasePriviledge, GetUseCasePriviledge>();//24
            services.AddTransient<IGetAllActiveBills, GetAllActiveBills>();//26
        }

        public static void AddCommandUseCases(this IServiceCollection services)
        {
            services.AddTransient<IRegisterNewTable, RegisterNewTable>();//1
            services.AddTransient<ICreateNewBill, CreateNewBill>(); //3
            services.AddTransient<IAddNewEmployee, AddNewEmployee>();//4
            services.AddTransient<IAddBillDetail, AddBillDetail>();//17
            services.AddTransient<ICloseBill, CloseBill>();//18
            services.AddTransient<IActivateUser, ActivateUser>();//19
            services.AddTransient<INewMenu, NewMenu>();//13
            services.AddTransient<IRemoveMenu, RemoveMenu>();//14
            services.AddTransient<IUpdateMenu, UpdateMenu>();//15
            services.AddTransient<INewSubType, NewSubType>();//9
            services.AddTransient<IRemoveSubType, RemoveSubType>();//10
            services.AddTransient<IUpdateSubType, UpdateSubType>();//11
            services.AddTransient<IAddNewType, AddNewType>();//5
            services.AddTransient<IRemoveType, RemoveType>();//6
            services.AddTransient<IUpdateType, UpdateType>();//7
            services.AddTransient<IAddPriviledgeToUser, AddPriviledgeToUser>();//20
            services.AddTransient<IAddUseCase, AddUseCase>();//21
            services.AddTransient<IRemovePriviledgeFromuser, RemovePriviledgeFromuser>();//22

        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddTransient<TableValidator>();
            services.AddTransient<NewBillValidator>();
            services.AddTransient<AddNewEmployeeValidator>();
            services.AddTransient<AddBillDetailValidator>();
            services.AddTransient<CloseBillValidator>();
            services.AddTransient<ActivateEmployeeValidation>();
            services.AddTransient<NewMenuValidator>();
            services.AddTransient<RemoveMenuValidator>();
            services.AddTransient<UpdateMenuValidator>();
            services.AddTransient<NewSubTypeValidator>();
            services.AddTransient<RemoveSubTypeValidator>();
            services.AddTransient<UpdateSubTypeValidator>();
            services.AddTransient<NewTypeValidator>();
            services.AddTransient<RemoveTypeValidator>();
            services.AddTransient<UpdateTypeValidator>();
            services.AddTransient<AddPriviledgeToUserValidator>();
            services.AddTransient<AddUseCaseValidator>();
            services.AddTransient<RemovePriviledgeFromUserValidator>();
            services.AddTransient<ImageValidation>();

        }

        public static void AddApplicationActor(this IServiceCollection services)
        {
            //Dummy actor
            //services.AddTransient<IAppActor, DummyActor>();

            //Kada bude doslo do jwt-a ovo odkomentarisati 
            services.AddTransient<IAppActor>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();
                var header = accessor.HttpContext.Request.Headers["Authorization"];

                var claims = accessor.HttpContext.User;

                if (claims == null || claims.FindFirst("UserId") == null)
                {
                    return new AnonymusUser();
                }

                var actor = new JwtUser()
                {
                    Id = Int32.Parse(claims.FindFirst("UserId").Value),
                    Identity = claims.FindFirst("Identity").Value,
                    AllowedActions = JsonConvert.DeserializeObject<List<int>>(claims.FindFirst("UseCases").Value)
                };

                return actor;
            });
        }
        public static void AddJwt(this IServiceCollection services)
        {

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = JwtConfig.JWTIssuer,
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtConfig.SecretKey)),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}
