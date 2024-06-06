using DesignPatterns.BehavioralPatterns.Mediator.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class MediatorController : ControllerBase
    {
        private readonly ILogger<MediatorController> _logger;
        private readonly MediatorContainer mediatorContainer;
        public MediatorController(ILogger<MediatorController> logger, MediatorContainer mediatorContainer)
        {
            _logger = logger;
            this.mediatorContainer = mediatorContainer;
        }

        [HttpGet("Pattern")]
        public async Task<IActionResult> Pattern()
        {
            mediatorContainer.Pattern();
            return Ok("~ Mediator ...");
        }
    }
}
