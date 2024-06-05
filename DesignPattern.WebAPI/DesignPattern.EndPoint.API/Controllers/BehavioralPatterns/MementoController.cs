using DataAccesses.Models.Entities.Security;
using DesignPattern.EndPoint.API.Controllers.Bases;
using DesignPatterns.BehavioralPatterns.Memento.Container;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    public class MementoController : BaseController<Person>
    {
        private readonly ILogger<MementoController> _logger;
        private readonly MementoContainer Container;
        public MementoController(ILogger<MementoController> logger, MementoContainer container)
        {
            _logger = logger;
            Container = container;
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
            Container.Pattern();
            
            return Ok(Container);
        }
        [HttpGet("PersonAction")]
        public IActionResult PersonAction()
        {
            Container.PersonActionExample();
            return Ok(Container);
        }

        public override Task<IActionResult> Read()
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Update()
        {
            throw new NotImplementedException();
        }
    }
}
