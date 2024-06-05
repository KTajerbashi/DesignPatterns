using DesignPattern.EndPoint.API.Controllers.Bases;
using DesignPatterns.BehavioralPatterns.Visitor.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    public class VisitorController : BaseController
    {
        private readonly ILogger<VisitorController> _logger;
        private readonly VisitorContainer visitorContainer;
        public VisitorController(ILogger<VisitorController> logger, VisitorContainer visitorContainer)
        {
            _logger = logger;
            this.visitorContainer = visitorContainer;
        }


        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            visitorContainer.Pattern();
            return Ok(visitorContainer);
        }
        [HttpGet("Taxi")]
        public IActionResult Taxi()
        {
            visitorContainer.Taxi();
            return Ok(visitorContainer);
        }
    }
}
