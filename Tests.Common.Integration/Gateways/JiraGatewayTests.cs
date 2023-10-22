namespace Kek5.Joho.Tests.Common.Integration.Gateways;

public class JiraGatewayTests : BaseTestFixture
{
    [Fact]
    public async Task JiraPing()
    {
        var test = await JiraGateway.PingJira();

        test.Should().BeTrue();
    }
    
}