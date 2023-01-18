using Todo.Models;

namespace Todo.Services
{
    public class Interfacer : IInterfacer
    {
        public void ListTodos(List<TodoItem> items)
        {
            throw new NotImplementedException();
        }

        public void ShowTodo(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void TodoAdded(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void TodoCompleted(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void TodoRemoved(TodoItem item)
        {
            throw new NotImplementedException();
        }
        
        public void Error(Exception error)
        {
            throw new NotImplementedException();
        }
    }
}