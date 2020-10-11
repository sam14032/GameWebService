using System.Threading.Tasks;
using GameWebService.API.Models.MovementAggregate;
using GameWebService.API.Models.PlayerAggregate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameWebService.API.Controllers
{
    [ApiController]
    [Route("Player/[controller]")]
    public class MovementController
    {
        private readonly ILogger<PlayerController> _logger;

        public MovementController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }
        public async Task<ActionResult> Post(PlayerId playerId, Direction direction)
        {
            return null;
        }
        
    }
}