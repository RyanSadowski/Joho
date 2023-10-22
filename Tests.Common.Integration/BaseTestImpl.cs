using System.Configuration;
using Kek5.Joho.Common.Gateways;
using Kek5.Joho.Common.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Kek5.Joho.Tests.Common.Integration;

public abstract class BaseTest : IClassFixture<BaseTestFixture>
{
    protected readonly IJiraGateway JiraGateway;

    protected BaseTest(BaseTestFixture fixture)
    {
        JiraGateway = fixture.JiraGateway;
    }

}

public class BaseTestFixture
{
    public IJiraGateway JiraGateway { get; }

    public BaseTestFixture()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<BaseTestFixture>()
            .Build();

        var apiKey = configuration["Jira:ApiKey"];
        var baseUri = configuration["Jira:BaseUri"];
        var email = configuration["Jira:Email"];

        if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(baseUri) || string.IsNullOrWhiteSpace(email))
        {
            throw new ConfigurationException();
        }

        var httpClient = new HttpClient();
        var token = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{email}:{apiKey}"));

        JiraGateway = new JiraGateway(httpClient, token, baseUri);
    }
}