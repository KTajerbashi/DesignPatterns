using DesignPatterns.BehavioralPatterns.Memento.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class MementoController : ControllerBase
    {
        private readonly ILogger<MementoController> _logger;
        private readonly MementoContainer Container;
        public MementoController(ILogger<MementoController> logger, MementoContainer container)
        {
            _logger = logger;
            Container = container;
        }

        [HttpGet(Name = "Pattern")]
        public IActionResult Pattern()
        {
            _logger.LogCritical("=================================================");
            Container.Pattern();
            _logger.LogCritical("=================================================");
            
            return Ok(Container);
        }
        [HttpGet("PersonAction")]
        public IActionResult PersonAction()
        {
            _logger.LogCritical("=================================================");
            Container.PersonActionExample();
            _logger.LogCritical("=================================================");
            return Ok(Container);
        }
    }
}
