using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class ChainOfResponsibilityController : ControllerBase
    {
        private readonly ILogger<ChainOfResponsibilityController> _logger;

        public ChainOfResponsibilityController(ILogger<ChainOfResponsibilityController> logger)
        {
            _logger = logger;
        }
    }
}
