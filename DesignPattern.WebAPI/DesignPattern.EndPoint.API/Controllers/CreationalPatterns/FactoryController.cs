using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.CreationalPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryController : ControllerBase
    {
        private readonly ILogger<FactoryController> _logger;
        public FactoryController(ILogger<FactoryController> logger)
        {
            _logger = logger;
        }
    }
}
