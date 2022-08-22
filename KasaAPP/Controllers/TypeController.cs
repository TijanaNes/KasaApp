using Application.Commands.Types;
using Application.Core;
using Application.Dto.TypesDto;
using Application.Queries.Types;
using Application.Searches.TypesSearches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly Executor executor;

        public TypeController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewTypeDto value, [FromServices] IAddNewType action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpDelete("idToDelete")]
        public IActionResult RemoveType(int value, [FromServices] IRemoveType action)
        {
            var MenuDto = new RemoveTypeDto()
            {
                IdToRemove = value
            };
            this.executor.ExecuteCommand(action, MenuDto);
            return NoContent();
        }
        [HttpPatch]
        public IActionResult UpdateType([FromBody] UpdateTypeDto value, [FromServices] IUpdateType action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }

        [HttpGet]
        public IActionResult getType([FromQuery] TypesSearches value, [FromServices] IGetType action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
    }
}
