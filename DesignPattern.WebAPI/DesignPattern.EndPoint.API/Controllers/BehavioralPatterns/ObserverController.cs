using DesignPattern.EndPoint.API.Logger.Tools;
using DesignPatterns.BehavioralPatterns.Observer.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class ObserverController : ControllerBase
    {
        private readonly ILogger<ObserverController> _logger;
        private readonly ObserverContainer observerContainer;

        public ObserverController(ILogger<ObserverController> logger, ObserverContainer observerContainer)
        {
            _logger = logger;
            this.observerContainer = observerContainer;
        }

        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            observerContainer.Pattern();
            _logger.LogInformation(EventLogId.QueryValidation, "ObserverController.Pattern() ....");
            return Ok();
        }
    }
}
