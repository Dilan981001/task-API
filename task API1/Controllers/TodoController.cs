using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using task_API1.Models;
using task_API1.Services;

namespace task_API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private TodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos() ;
            if (id is null) return Ok(myTodos);
            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

       
    }
}
