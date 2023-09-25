using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace vams_onair_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly ILogger<AircraftController> _logger;

        public AircraftController(ILogger<AircraftController> logger)
        {
            _logger = logger;
        }

        
    }
}
