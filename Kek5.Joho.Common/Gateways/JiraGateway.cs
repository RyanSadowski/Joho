using System.Net.Http.Headers;
using System.Text;
using Kek5.Joho.Common.Interfaces;

namespace Kek5.Joho.Common.Gateways;

public class JiraGateway: IJiraGateway {
	
	private readonly HttpClient _httpClient;
	private readonly string _baseUri;

	public JiraGateway(HttpClient httpClient, string key, string baseUri)
	{
		_httpClient = httpClient;
		_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",key);
		_baseUri = baseUri;
	}

	public Task<object> GetIssueAsync(string project, string key)
	{
		throw new NotImplementedException();
	}

	public async Task<bool> PingJira() {
		try
		{
			var response = await _httpClient.GetAsync($"{_baseUri}/rest/api/3/issue/10000");

			// Here, we're considering any successful status code as a healthy response.
			// Some APIs might return detailed health information in the response body,
			// which you could parse and check as needed.

			// if (!response.IsSuccessStatusCode) return false;
			// response.Content is of type HttpContent and ReadAsStringAsync is an async method to read content as a string
			
			
			string responseBody = await response.Content.ReadAsStringAsync();

			// Now you can work with the response body as a string
			Console.WriteLine(responseBody);

			return response.IsSuccessStatusCode;
		}
		catch (Exception ex)
		{
			// Log the exception (consider using a logging framework like Serilog, NLog, etc.)
			Console.WriteLine($"An error occurred while checking the API health: {ex.Message}");
			return false;
		}
	}
}
