using Kek5.Joho.Gateways.Interfaces;

namespace Kek5.Joho.Gateways;

public class JiraGateway: IJiraGateway {

	private readonly String _key;
	private readonly String _baseUri;

	public JiraGateway(String key, String baseUri) {

		_key = key;
		_baseUri = baseUri;

	}

	public async Task<String> PingJira() {

		return "Jira Was Pung";
	}

}
