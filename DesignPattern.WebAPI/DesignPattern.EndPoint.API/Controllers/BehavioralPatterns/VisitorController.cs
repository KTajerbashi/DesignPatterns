using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class VisitorController : ControllerBase
    {
        private readonly ILogger<VisitorController> _logger;

        public VisitorController(ILogger<VisitorController> logger)
        {
            _logger = logger;
        }
    }
}
