using DataAccesses.Models.Entities;
using DataAccesses.Models.Entities.Security;
using DesignPattern.EndPoint.API.Controllers.Bases;
using DesignPatterns.BehavioralPatterns.Visitor.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    public class VisitorController : BaseController<Person>
    {
        private readonly ILogger<VisitorController> _logger;
        private readonly VisitorContainer visitorContainer;
        public VisitorController(ILogger<VisitorController> logger, VisitorContainer visitorContainer)
        {
            _logger = logger;
            this.visitorContainer = visitorContainer;
        }

        public override Task<IActionResult> Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Delete()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Pattern")]
        public IActionResult Pattern()
        {
            visitorContainer.Pattern();
            return Ok(visitorContainer);
        }

        public override Task<IActionResult> Read()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Taxi")]
        public IActionResult Taxi()
        {
            visitorContainer.Taxi();
            return Ok(visitorContainer);
        }

        public override Task<IActionResult> Update()
        {
            throw new NotImplementedException();
        }
    }
}
