using Microsoft.AspNetCore.Mvc;

namespace api_sre_automation_toolkit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "BASH", "PowerShell", "C#"
        ];

        [HttpGet(Name = "GetTools")]
        public IEnumerable<Tool> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Tool
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
