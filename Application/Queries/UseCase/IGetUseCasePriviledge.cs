using Application.Core;
using Application.Dto;
using Application.Dto.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.UseCase
{
    public interface IGetUseCasePriviledge : IQuery<EmptySearchDto,IEnumerable<GetUseCasePriviledgeDto>>
    {
    }
}
