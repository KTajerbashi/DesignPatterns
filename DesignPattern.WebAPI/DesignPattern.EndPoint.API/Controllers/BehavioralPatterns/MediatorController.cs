using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class MediatorController : ControllerBase
    {
        private readonly ILogger<MediatorController> _logger;

        public MediatorController(ILogger<MediatorController> logger)
        {
            _logger = logger;
        }
    }
}
