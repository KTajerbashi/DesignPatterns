using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class FlyweightController : ControllerBase
    {
        private readonly ILogger<FlyweightController> _logger;
        public FlyweightController(ILogger<FlyweightController> logger)
        {
            _logger = logger;
        }
    }
}
