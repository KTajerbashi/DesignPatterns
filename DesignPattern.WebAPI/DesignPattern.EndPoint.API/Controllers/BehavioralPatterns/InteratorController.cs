using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class InteratorController : ControllerBase
    {
        private readonly ILogger<InteratorController> _logger;

        public InteratorController(ILogger<InteratorController> logger)
        {
            _logger = logger;
        }
    }
}
