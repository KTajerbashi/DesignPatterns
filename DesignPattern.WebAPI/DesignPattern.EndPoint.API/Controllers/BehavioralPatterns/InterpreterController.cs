using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class InterpreterController : ControllerBase
    {
        private readonly ILogger<InterpreterController> _logger;

        public InterpreterController(ILogger<InterpreterController> logger)
        {
            _logger = logger;
        }

    }
}
