using Spectre.Console;
using Todo.Models;

namespace Todo.Services
{
    public static class Interfacer
    {
        public static void ListTodos(List<TodoItem> items)
        {
            var table = new Table();
            table.AddColumn(new TableColumn("Id"));
            table.AddColumn(new TableColumn("Todo"));
            table.AddColumn(new TableColumn("Done"));
            foreach(var item in items)
            {
                var done = item.Done ? "Yes" : "No";
                table.AddRow(item.Id.ToString(), item.Name, done);
            }

            AnsiConsole.Write(table);
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