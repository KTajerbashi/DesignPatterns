using DesignPattern.EndPoint.API.Logger.Tools;
using DesignPatterns.BehavioralPatterns.Iterator.Container;
using DesignPatterns.BehavioralPatterns.State.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : ControllerBase
    {
        private readonly ILogger<StateController> _logger;
        private readonly StateContainer stateContainer;
        public StateController(ILogger<StateController> logger, StateContainer stateContainer)
        {
            _logger = logger;
            this.stateContainer = stateContainer;
        }

        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            stateContainer.Pattern();
            _logger.LogInformation(EventLogId.QueryValidation, "StateController.Pattern() ....");
            return Ok();
        }
        [HttpGet("OrderState")]
        public IActionResult OrderState()
        {
            stateContainer.OrderState();
            _logger.LogInformation(EventLogId.QueryValidation, "StateController.OrderState() ....");
            return Ok();
        }
    }
}
