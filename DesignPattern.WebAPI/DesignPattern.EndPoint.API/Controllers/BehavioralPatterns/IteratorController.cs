using DesignPattern.EndPoint.API.Logger.Tools;
using DesignPatterns.BehavioralPatterns.Iterator.Container;
using DesignPatterns.BehavioralPatterns.Observer.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class IteratorController : ControllerBase
    {
        private readonly ILogger<IteratorController> _logger;
        private readonly IteratorContainer IteratorContainer;

        public IteratorController(ILogger<IteratorController> logger, IteratorContainer iteratorContainer)
        {
            _logger = logger;
            IteratorContainer = iteratorContainer;
        }
        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            IteratorContainer.Pattern();
            _logger.LogInformation(EventLogId.QueryValidation, "IteratorController.Pattern() ....");
            return Ok();
        }
    }
}
