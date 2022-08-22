using Application.Commands.UseCase;
using Application.Core;
using Application.Dto;
using Application.Dto.UseCase;
using Application.Queries.Log;
using Application.Queries.UseCase;
using Application.Searches.LogSearches;
using Implementation.Queries.Log;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UseCaseController : ControllerBase
    {
        private readonly Executor executor;

        public UseCaseController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpPost("AddPrivledgeToUser")]
        public IActionResult AddPrivledge([FromBody] AddPriviledgeToUserDto value, [FromServices] IAddPriviledgeToUser action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpPost("UseCaseAdd")]
        public IActionResult AddUseCase([FromBody] AddUseCaseDto value, [FromServices] IAddUseCase action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpDelete("idToDelete")]
        public IActionResult RemovePrivledge(int value, [FromServices] IRemovePriviledgeFromuser action)
        {
            var MenuDto = new RemovePriviledgeFromUser()
            {
                 Id = value
            };
            this.executor.ExecuteCommand(action, MenuDto);
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAllUseCase([FromQuery] EmptySearchDto value, [FromServices] IGetUseCase action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
        [HttpGet("UseCasePrivledge")]
        public IActionResult previewUseCasePriveldge([FromQuery] EmptySearchDto value, [FromServices] IGetUseCasePriviledge action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
        [HttpGet("LogPreview")]
        public IActionResult LogPreview([FromQuery] LogSearch value, [FromServices] IGetAllLog action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
    }
}
