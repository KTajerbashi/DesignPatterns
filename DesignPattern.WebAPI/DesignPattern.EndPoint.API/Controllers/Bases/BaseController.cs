using DataAccesses.Models.Entities.Bases;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.EndPoint.API.Controllers.Bases
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController<TEntity> : ControllerBase
        where TEntity : BaseEntity
    {

        [HttpPost("Create")]
        public abstract Task<IActionResult> Create(TEntity entity);

        [HttpGet("Read")]
        public abstract Task<IActionResult> Read();

        [HttpPut("Update")]
        public abstract Task<IActionResult> Update();

        [HttpDelete("Delete")]
        public abstract Task<IActionResult> Delete();

    }
}
