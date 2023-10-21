using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Kek5.Joho.Gateways;
using Kek5.Joho.Gateways.Interfaces;
using Kek5.Joho.Factories.Interfaces;
using Kek5.Joho.Factories;

namespace Kek5.Joho;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .AddUserSecrets<Program>();

        var configuration = builder.Build();

        // Set up Dependency Injection
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection, configuration);
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var commandFactory = serviceProvider.GetService<ICommandFactory>();

        // Do the thing
        try
        {
            var inputData = Parsley.ParseArguments(args);
            var command = commandFactory.CreateCommand(inputData);
            Console.WriteLine(command);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle exception or print usage information
        }
    }

    private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        // Register services with DI here
        services.AddTransient<IJiraGateway>(_ => new JiraGateway(configuration["API_KEY"]!, configuration["BASE_URI"]!));
        services.AddTransient<IGitLabGateway>(_ => new GitLabGateway());
        services.AddTransient<ICommandFactory>(_ => new CommandFactory());
    }


}
