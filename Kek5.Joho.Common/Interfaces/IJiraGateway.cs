namespace Kek5.Joho.Common.Interfaces;

public interface IJiraGateway
{
    Task<object> GetIssueAsync(string project, string key);
    Task<bool> PingJira();
    
}