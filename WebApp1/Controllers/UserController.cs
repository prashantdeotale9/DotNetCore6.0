using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            return StatusCode(200);
        }
    }
}
