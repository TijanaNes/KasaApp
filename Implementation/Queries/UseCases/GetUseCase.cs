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
    public class GetUseCase : IGetUseCase
    {
        private readonly Context context;

        public GetUseCase(Context context)
        {
            this.context = context;
        }

        public int Id_UseCase => 23;

        public string Name_UseCase => "Get all usecases";

        public IEnumerable<GetUseCaseDto> Query(EmptySearchDto search)
        {
            return context.UseCases.Select(x => new GetUseCaseDto()
            {
                Name = x.Name,
                Id = x.Id,
                UseCaseIdentifier = x.UseCaseIdentifier
            }).ToList();
        }
    }
}
