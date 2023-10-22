using Kek5.Joho.Common.Factories;
using Kek5.Joho.Common.Gateways;
using Kek5.Joho.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kek5.Joho.Cli;

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

        var baseJiraUri = configuration["Jira:BaseUri"];
        var jiraApiKey = configuration["Jira:ApiKey"];
        var jiraApiEmail = configuration["Jira:Email"];
        
        var token = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{jiraApiEmail}:{jiraApiKey}"));
        
        
        services.AddTransient<IJiraGateway>(_ => new JiraGateway(new HttpClient(), token, baseJiraUri));
        services.AddTransient<IGitLabGateway>(_ => new GitLabGateway());
        services.AddTransient<ICommandFactory>(provider => new CommandFactory(provider.GetService<IJiraGateway>()));
    }


}
