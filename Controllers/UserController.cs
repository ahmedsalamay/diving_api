using diving_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace diving_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        DivingContext context;

        private readonly ILogger<UserController> _logger;

        public UserController(DivingContext context, ILogger<UserController> logger)
        {
            _logger = logger;
            this.context = context;

        }

        [HttpGet("{code}")]
        public async Task<ActionResult<User>> Get(int code)
        {
            var user = await context.ro01.FirstOrDefaultAsync((u) => u.rcode == code);
            if (user == null) return  BadRequest();
            else return Ok(user);
        }
    }
}
