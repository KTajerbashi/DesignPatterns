using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class DecoratorController : ControllerBase
    {
        private readonly ILogger<DecoratorController> _logger;
        public DecoratorController(ILogger<DecoratorController> logger)
        {
            _logger = logger;
        }
    }
}
