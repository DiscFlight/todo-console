using Microsoft.Extensions.DependencyInjection;
using Todo.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        foreach(var arg in args)
        {
            Console.WriteLine(arg);
        }
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton<ITodoDataService, TodoDataService>()
            .AddSingleton<IInterfacer, Interfacer>();
    }
}