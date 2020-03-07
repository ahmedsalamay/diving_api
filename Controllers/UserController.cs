using diving_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
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
        public User Get(int code)
        {
            var c = context.ro01.FirstOrDefault((u) => u.rcode == code);
            return c;
        }
    }
}
