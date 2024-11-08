using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using task_API1.Services;
using TaskAPI.Service;

namespace task_API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodoController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllToDos();
            if (id is null) return Ok(myTodos);
            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

       
    }
}
