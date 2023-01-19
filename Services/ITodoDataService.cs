using Todo.Models;

namespace Todo.Services
{
    public interface ITodoDataService
    {
        TodoItem GetTodo(int id);
        List<TodoItem> GetTodos();
        void CreateTodo(TodoItem todo);
        void CompleteTodo(int id);
        void DeleteTodo(int id);
    }
}