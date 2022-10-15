using Microsoft.AspNetCore.Mvc;

namespace Source.DevOps.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Login")]
        public IActionResult Login(string email, string password)
        {
            if (email == "test@gmail.com" && password == "123456")
                return Ok("success");

            return BadRequest("failed");
        }
    }
}
