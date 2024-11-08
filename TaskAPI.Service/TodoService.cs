using task_API1.Models;
using System.Collections.Generic;

namespace task_API1.Services
{
    public class TodoService
    {
        //get todos
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get vegetbles",
                Description = "Get vegetables for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo2);
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water all plants",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New

            };
            todos.Add(todo3);
            return todos;
        }
    }
}
