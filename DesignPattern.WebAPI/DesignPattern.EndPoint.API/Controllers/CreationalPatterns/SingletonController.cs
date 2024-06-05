using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.CreationalPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class SingletonController : ControllerBase
    {
        private readonly ILogger<SingletonController> _logger;
        public SingletonController(ILogger<SingletonController> logger)
        {
            _logger = logger;
        }
    }
}
