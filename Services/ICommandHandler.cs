namespace Todo.Services
{
    public interface ICommandHandler
    {
        void Run(string[] args);
    }
}