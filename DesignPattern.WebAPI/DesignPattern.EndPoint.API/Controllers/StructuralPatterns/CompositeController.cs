using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class CompositeController : ControllerBase
    {
        private readonly ILogger<CompositeController> _logger;
        public CompositeController(ILogger<CompositeController> logger)
        {
            _logger = logger;
        }
    }
}
