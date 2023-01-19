using Newtonsoft.Json;
using Todo.Models;

namespace Todo.Services
{
    public class MockDataService : ITodoDataService
    {
        private readonly string _filePath = $"{Environment.CurrentDirectory}\\mockdb.json";

        private List<TodoItem> _todos = new List<TodoItem>();
        public MockDataService()
        {
            if(!File.Exists(_filePath))
            {
                // Creates the file and appends correct json.
                SaveChanges();
            }

            ReadFromFile();
        }

        public TodoItem? GetTodo(int id)
        {
            var todo = _todos
                .Where(x => x.Id == id)
                .SingleOrDefault();

            if(todo == null)
            {
                Interfacer.Error(new NotFoundException());
                return null;
            }

            return todo;
        }

        public List<TodoItem> GetTodos()
        {
            return _todos;
        }

        public void CreateTodo(TodoItem todo)
        {
            todo.Id = _todos.Any()
                ? (_todos.Max(x => x.Id) + 1)
                : 1;

            _todos.Add(todo);

            var saveSucceded = SaveChanges();

            if(saveSucceded)
            {
               Interfacer.TodoAdded(todo); 
            }
        }

        public void CompleteTodo(int id)
        {
            var todo = GetTodo(id);

            if(todo == null)
            {
                Interfacer.Error(new NotFoundException());
                return;    
            }

            todo.Done = !todo.Done;

            var saveSucceded = SaveChanges();

            if(saveSucceded)
            {
                Interfacer.TodoCompleted(todo);
            }
        }

        public void DeleteTodo(int id)
        {
            var todo = GetTodo(id);

            if(todo == null)
            {
                Interfacer.Error(new NotFoundException());
                return;
            }

            _todos.Remove(todo);
            var saveSucceded = SaveChanges();

            if(saveSucceded)
            {
                Interfacer.TodoRemoved(todo);
            }
        }

        private bool SaveChanges()
        {
            return SaveToFile();
        }
        
        private bool ReadFromFile()
        {
            string? jsonData = "";
            try
            {
                jsonData = File.ReadAllText(_filePath);  
            }
            catch (System.Exception exc)
            {
                Interfacer.Error(exc);
                return false;
            }

            if(jsonData == null)
            {
                Interfacer.Error(new DataSourceException());
                return false;
            }

            _todos = JsonConvert.DeserializeObject<List<TodoItem>>(jsonData) ?? new List<TodoItem>();

            return true;
        }

        private bool SaveToFile()
        {
            var todos = JsonConvert.SerializeObject(_todos);

            try
            {
                File.WriteAllText(_filePath, todos);
                return true;
            }
            catch (System.Exception exc)
            {
                Interfacer.Error(exc);
                return false;
            }
        }
    }
}