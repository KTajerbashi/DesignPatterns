using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class StrategyController : ControllerBase
    {
        private readonly ILogger<StrategyController> _logger;

        public StrategyController(ILogger<StrategyController> logger)
        {
            _logger = logger;
        }
    }
}
