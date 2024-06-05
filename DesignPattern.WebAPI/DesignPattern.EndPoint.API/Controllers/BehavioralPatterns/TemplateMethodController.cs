using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.BehavioralPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateMethodController : ControllerBase
    {
        private readonly ILogger<TemplateMethodController> _logger;

        public TemplateMethodController(ILogger<TemplateMethodController> logger)
        {
            _logger = logger;
        }
    }
}
