using Application.Commands.Employees;
using Application.Core;
using Application.Dto.EmployeeDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Executor executor;

        public EmployeeController(Executor executor)
        {
            this.executor = executor;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddNewEmloyeeDto value, [FromServices] IAddNewEmployee action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        
        [HttpGet("ActivateAccount")]
        public IActionResult ActivateAccount([FromQuery] ActivateEmployeeDto passKey, [FromServices] IActivateUser command)
        {
            this.executor.ExecuteCommand(command, passKey);
            return NoContent();
        }
    }
}
