using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace task_API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "task1", "task2", "task3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
