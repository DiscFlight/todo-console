using Todo.Models;

namespace Todo.Services
{
    public class CommandHandler
    {
        public ITodoDataService _dataService { get; }
        public IInterfacer _interfacer { get; }
        public CommandHandler(ITodoDataService dataService, IInterfacer interfacer)
        {
            _interfacer = interfacer;
            _dataService = dataService;
            
        }
        public void Run(string[] args) 
        {
            var command = args[0];
            var data = args[1];

            switch(command.ToLower())
            {
                case "list":
                case "l":
                case null:
                    ListTodos();
                    break;
                case "show":
                case "s":
                    if (int.TryParse(data, out int id))
                    {
                        _interfacer.Error(new IdMissingException("No id provided. Correct format is 'todo show {id}'"));
                    }
                    ShowTodo(id);
                    break;
                case "add":
                case "a":
                    break;
                case "done":
                case "d":
                    break;
                case "remove":
                case "r":
                    break;
            }
        }

        private void ListTodos()
        {
            var todos = _dataService.GetTodos();

            _interfacer.ListTodos(todos);
        }

        private void ShowTodo(int id)
        {
            var todo = _dataService.GetTodo(id)
        }
    }
}