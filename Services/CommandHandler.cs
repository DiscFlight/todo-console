using System.Text;
using Todo.Models;

namespace Todo.Services
{

    public class CommandHandler : ICommandHandler
    {
        private ITodoDataService _dataService { get; }
        public CommandHandler()
        {
            _dataService = new MockDataService();
        }

        public void Run(string[] args)
        {
            var command = args.Any() 
                ? args[0] 
                : "list";
            
            var argumentBuilder = new StringBuilder();
            for (int i = 1; i < args.Length; i++)
            {
                argumentBuilder.Append(" " + args[i]);
            }

            var argument = argumentBuilder.ToString();

            switch (command.ToLower())
            {
                case "list":
                case "l":
                case null:
                    ListTodos();
                    break;

                case "show":
                case "s":
                    ShowTodo(argument);
                    break;

                case "add":
                case "a":
                    AddTodo(argument);
                    break;

                case "done":
                case "d":
                    CompleteTodo(argument);
                    break;
                    
                case "remove":
                case "r":
                    RemoveTodo(argument);
                    break;
            }
        }

        private void ListTodos()
        {
            var todos = _dataService.GetTodos();

            Interfacer.ListTodos(todos);
        }

        private void ShowTodo(string? data)
        {
            if (!int.TryParse(data, out int id))
            {
                Interfacer.Error(new IdMissingException());

                return;
            }

            var todo = _dataService.GetTodo(id);

            Interfacer.ShowTodo(todo);
        }

        private void AddTodo(string? data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                Interfacer.Error(new NameMissingException());

                return;
            }
            var todo = new TodoItem(data);

            _dataService.CreateTodo(todo);
        }

        private void CompleteTodo(string? data)
        {
            if (!int.TryParse(data, out int id))
            {
                Interfacer.Error(new IdMissingException());

                return;
            }

            _dataService.CompleteTodo(id);
        }

        private void RemoveTodo(string? data)
        {
            if (!int.TryParse(data, out int id))
            {
                Interfacer.Error(new IdMissingException());

                return;
            }

            _dataService.DeleteTodo(id);
        }
    }
}