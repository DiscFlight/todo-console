using Todo.Models;

namespace Todo.Services
{
    public static class Interfacer
    {
        public static void ListTodos(List<TodoItem> items)
        {
            foreach(var item in items)
            {
                ShowTodo(item);
            }
        }

        public static void ShowTodo(TodoItem item)
        {
            var done = item.Done ? "Yes" : "No";
            Console.WriteLine($" Id: {item.Id}\tName: {item.Name}\t Done: {done}");
        }

        public static void TodoAdded(TodoItem item)
        {
            Console.WriteLine($"{item.Name} has been added to your list of todos.");
        }

        public static void TodoCompleted(TodoItem item)
        {
            if(item.Done)
                Console.WriteLine($"{item.Name} is done, good job!");
            else
                Console.WriteLine($"{item.Name} has been reset.");
        }

        public static void TodoRemoved(TodoItem item)
        {
            Console.WriteLine($"{item.Name} has been removed!");
        }
        
        public static void Error(Exception error)
        {
            Console.WriteLine(ConstructErrorMessage(error));
        }

        private static string ConstructErrorMessage(Exception error)
        {
            return error.InnerException?.Message ?? error.Message;
        }
    }
}