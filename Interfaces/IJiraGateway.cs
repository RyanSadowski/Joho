
namespace Kek5.Joho.Gateways.Interfaces;

public interface IJiraGateway
{
    Task GetIssueAsync(string project, string key);
}
