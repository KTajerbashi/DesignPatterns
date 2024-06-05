using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class AdapterController : ControllerBase
    {
        private readonly ILogger<AdapterController> _logger;
        public AdapterController(ILogger<AdapterController> logger)
        {
            _logger = logger;
        }
    }
}
