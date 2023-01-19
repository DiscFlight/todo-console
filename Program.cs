using Microsoft.Extensions.DependencyInjection;
using Todo.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        new CommandHandler()
            .Run(args);
    }
}