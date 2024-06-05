using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class ChainOfResponsibility  : ControllerBase
    {
        private readonly ILogger<ChainOfResponsibility> _logger;

        public ChainOfResponsibility(ILogger<ChainOfResponsibility> logger)
        {
            _logger = logger;
        }
    }
}
