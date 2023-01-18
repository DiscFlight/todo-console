using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Services
{
    public interface IInterfacer
    {
        void ListTodos(List<TodoItem> items);
        void ShowTodo(TodoItem item);
        void TodoAdded(TodoItem item);
        void TodoCompleted(TodoItem item);
        void TodoRemoved(TodoItem item);
        void Error(Exception error);
    }
}