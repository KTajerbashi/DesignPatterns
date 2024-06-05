using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.CreationalPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class PrototypeController : ControllerBase
    {
        private readonly ILogger<PrototypeController> _logger;
        public PrototypeController(ILogger<PrototypeController> logger)
        {
            _logger = logger;
        }
    }
}
