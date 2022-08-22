using Application.Commands.Menus;
using Application.Core;
using Application.Dto.MenusDto;
using Application.Queries.Menus;
using Application.Searches.MenuSearches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly Executor executor;

        public MenuController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpPost]
        public IActionResult Post([FromForm] NewMenuDto value, [FromServices] INewMenu action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpDelete("idToDelete")]
        public IActionResult RemoveMenu(int value, [FromServices] IRemoveMenu action)
        {
            var MenuDto = new RemoveMenuDto()
            {
                IdToRemove = value
            };
            this.executor.ExecuteCommand(action, MenuDto);
            return NoContent();
        }
        [HttpPatch]
        public IActionResult UpdateMenu([FromForm] UpdateMenuDto value, [FromServices] IUpdateMenu action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }

        [HttpGet]
        public IActionResult getMenu([FromQuery] MenuSearch value, [FromServices] IGetmenus action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }

    }
}
