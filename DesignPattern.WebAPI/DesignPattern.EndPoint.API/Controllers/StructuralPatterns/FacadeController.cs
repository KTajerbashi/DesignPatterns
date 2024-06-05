using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.StructuralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class FacadeController : ControllerBase
    {
        private readonly ILogger<FacadeController> _logger;
        public FacadeController(ILogger<FacadeController> logger)
        {
            _logger = logger;
        }
    }
}
