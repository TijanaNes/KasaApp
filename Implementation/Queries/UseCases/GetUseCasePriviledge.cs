using Application.Core;
using Application.Dto;
using Application.Dto.UseCase;
using Application.Queries.UseCase;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Queries.UseCases
{
    public class GetUseCasePriviledge : IGetUseCasePriviledge
    {
        private readonly Context context;

        public GetUseCasePriviledge(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 24;

        public string Name_UseCase => "Get use case priviledges";

        public IEnumerable<GetUseCasePriviledgeDto> Query(EmptySearchDto search)
        {
            return this.context.Employees.Select(x => new GetUseCasePriviledgeDto()
            {
                IdUser = x.Id,
                NameUser = x.Name + " " + x.LastName,
                UseCaseList = x.User_UseCases.Select(y => new useCaseInternal()
                {
                    IdUseCase = y.UseCase.Id,
                    NameUseCase = y.UseCase.Name,
                    UseCaseIdentifier = y.UseCase.UseCaseIdentifier
                }).ToList()
            }).ToList(); 
        }
    }
}
