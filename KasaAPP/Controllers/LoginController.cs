using KasaAPP.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KasaAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly JwtGenerator generator;
        public LoginController(JwtGenerator generator)
        {
            this.generator = generator;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginCredentials Credential)
        {
            var token = generator.MakeToken(Credential.UserName, Credential.Password);

            return Ok(new { Token = token.FirstOrDefault() });
        }
    }
    public class LoginCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
