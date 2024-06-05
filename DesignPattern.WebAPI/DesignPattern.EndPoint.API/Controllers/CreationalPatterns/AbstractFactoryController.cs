using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.CreationalPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class AbstractFactoryController : ControllerBase
    {
        private readonly ILogger<AbstractFactoryController> _logger;
        public AbstractFactoryController(ILogger<AbstractFactoryController> logger)
        {
            _logger = logger;
        }
    }
}
