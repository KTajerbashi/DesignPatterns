using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.CreationalPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class BuilderController : ControllerBase
    {
        private readonly ILogger<BuilderController> _logger;
        public BuilderController(ILogger<BuilderController> logger)
        {
            _logger = logger;
        }
    }
}
