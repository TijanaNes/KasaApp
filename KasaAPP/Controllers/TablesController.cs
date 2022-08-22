using Application.Commands.Tables;
using Application.Core;
using Application.Dto.TablesDto;
using Application.Queries.Bills;
using Application.Queries.Tables;
using Application.Searches.BillSearch;
using Application.Searches.TablesSearches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly Executor executor;

        public TablesController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpGet]
        public IActionResult Post([FromQuery] TableSearch value, [FromServices] IGetTables action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
        [HttpGet("GetActiveBills")]
        public IActionResult getActiveBills([FromQuery] BillSearch value, [FromServices] IGetAllActiveBills action)
        {
            return Ok(this.executor.ExecuteQuery(action, value));
        }
        [HttpPost]
        public IActionResult Get([FromBody] RegisterNewTableDto newTable , [FromServices] IRegisterNewTable command)
        {
            this.executor.ExecuteCommand(command, newTable);

            return Ok();
        }
    }
}
