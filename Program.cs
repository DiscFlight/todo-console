using Microsoft.Extensions.DependencyInjection;
using Todo.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        new CommandHandler()
            .Run(args);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton<ICommandHandler, CommandHandler>()
            .AddSingleton<ITodoDataService, MockDataService>();
    }
}