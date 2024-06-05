using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class ProxyController : ControllerBase
    {
        private readonly ILogger<ProxyController> _logger;
        public ProxyController(ILogger<ProxyController> logger)
        {
            _logger = logger;
        }
    }
}
