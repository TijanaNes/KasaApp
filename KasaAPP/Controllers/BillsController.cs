using Application.Commands.Bills;
using Application.Core;
using Application.Dto.BillsDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KasaAPP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly Executor executor;

        public BillsController(Executor executor)
        {
            this.executor = executor;
        }


        // POST api/<BillsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateNewBillDto value, [FromServices] ICreateNewBill action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
        [HttpPost("AddBillDetail")]
        public IActionResult addBillDetail([FromBody] AddBillDetailDto value, [FromServices] IAddBillDetail action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }

        [HttpPatch("CloseBill")]
        public IActionResult CloseBill([FromBody] CloseBillDto value, [FromServices] ICloseBill action)
        {
            this.executor.ExecuteCommand(action, value);
            return Ok();
        }
    }
}
