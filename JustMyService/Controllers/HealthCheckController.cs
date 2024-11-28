using System;
using Microsoft.AspNetCore.Mvc;

namespace JustMyService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Status = "Healthy", Timestamp = DateTime.Now });
        }
    }
}