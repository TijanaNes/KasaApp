using Application.Commands.SubTypes;
using Application.Core;
using Application.Dto.SubTypesDto;
using Application.Queries.SubTypes;
using Application.Searches.SubTypeSearches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SubTypeController : ControllerBase
    {
        private readonly Executor executor;

        public SubTypeController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewSubTypeDto value, [FromServices] INewSubType action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpDelete("idToDelete")]
        public IActionResult RemoveSubType(int value, [FromServices] IRemoveSubType action)
        {
            var MenuDto = new RemoveSubTypeDto()
            {
                IdToRemove = value
            };
            this.executor.ExecuteCommand(action, MenuDto);
            return NoContent();
        }
        [HttpPatch]
        public IActionResult UpdateSubType([FromBody] UpdateSubTypeDto value, [FromServices] IUpdateSubType action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }

        [HttpGet]
        public IActionResult getSubType([FromQuery] SubTypeSearch value, [FromServices] IGetSubType action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
    }
}
