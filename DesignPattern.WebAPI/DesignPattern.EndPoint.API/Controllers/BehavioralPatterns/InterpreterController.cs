using DesignPattern.EndPoint.API.Logger.Tools;
using DesignPatterns.BehavioralPatterns.Interpreter.Container;
using DesignPatterns.BehavioralPatterns.Iterator.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class InterpreterController : ControllerBase
    {
        private readonly ILogger<InterpreterController> _logger;
        private readonly InterpreterContainer container;
        public InterpreterController(ILogger<InterpreterController> logger, InterpreterContainer container)
        {
            _logger = logger;
            this.container = container;
        }

        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            container.Pattern();
            _logger.LogInformation(EventLogId.QueryValidation, "InterpreterContainer.Pattern() ....");
            return Ok();
        }
        [HttpGet("DatetimeInterpreter")]
        public IActionResult DatetimeInterpreter(string input)
        {
            _logger.LogInformation(EventLogId.QueryValidation, "InterpreterContainer.DatetimeInterpreterExecute() ....");
            return Ok(container.DatetimeInterpreterExecute(input));
        }

    }
}
