using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_API1.Models;

namespace TaskAPI.Service
{
    public interface ITodoRepository
    {
        public List<Todo> AllToDos();
        
    }
}
