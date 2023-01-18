namespace Todo.Models
{
    public class IdMissingException : Exception
    {
        public IdMissingException(string message)
            :base(message)
        {}
    }
}