namespace Todo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; } = false;

        public TodoItem(string name)
        {
            Name = name;
        }
    }
}