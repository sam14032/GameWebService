using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameWebService.API.Controllers
{
    [ApiController]
    [Route("Player/[controller]")]
    public class PlayerController
    {
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            return null;
        }
        
    }
}