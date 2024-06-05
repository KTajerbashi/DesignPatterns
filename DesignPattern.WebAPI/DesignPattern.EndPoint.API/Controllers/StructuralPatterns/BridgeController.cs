using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class BridgeController : ControllerBase
    {
        private readonly ILogger<BridgeController> _logger;
        public BridgeController(ILogger<BridgeController> logger)
        {
            _logger = logger;
        }
    }
}
