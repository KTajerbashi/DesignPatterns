using DesignPattern.EndPoint.API.Logger.Tools;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class ObserverController : ControllerBase
    {
        private readonly ILogger<ObserverController> _logger;

        public ObserverController(ILogger<ObserverController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            _logger.LogInformation(EventLogId.QueryValidation, "ObserverController.Pattern() ....");
            return Ok();
        }
    }
}
