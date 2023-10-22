using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using Kek5.Joho.Common.Enums;
using Kek5.Joho.Common.Interfaces;

namespace Kek5.Joho.Common.Domain;

public class GetIssueCommand : ICommand
{
    private readonly IJiraGateway? _jiraGateway;

    public GetIssueCommand(IJiraGateway? jiraGateway, InputData data) {
        _jiraGateway = jiraGateway;
        if (data.CommandType != Commands.CreateIssue)
        {
            // cry
        }

        CommandType = Commands.CreateIssue;
        Paramz = data.Paramz;
        OutputFormat = data.OutputFormat;
    }

    public Commands CommandType { get; set; }

    public OutputFormat OutputFormat { get; set; } = OutputFormat.PlainText;

    public Dictionary<FlagTypes, string> Paramz { get; set; } = new Dictionary<FlagTypes, string>();

    public bool Validate() {
        var hasProjectKey = Paramz.ContainsKey(FlagTypes.Project);
        var hasIssueKey = Paramz.ContainsKey(FlagTypes.Key);

        return hasProjectKey && hasIssueKey;
    }

    public async Task<bool> Execute() {
        var project = Paramz[FlagTypes.Project];
        var key = Paramz[FlagTypes.Key];

        var result = await _jiraGateway.GetIssueAsync(project, key);

        return true;
    }

    public void Print() {

        var options = new JsonSerializerOptions
        {
            WriteIndented = true, // For pretty-printing
            Converters = { new JsonStringEnumConverter() } // Serialize enums as strings
        };
        
        string jsonString = JsonSerializer.Serialize(Paramz, options);

        System.Console.WriteLine($"Command : {CommandType}");
        System.Console.WriteLine($"Params : {jsonString}");
        System.Console.WriteLine($"Output Format: {OutputFormat}");
    }
}
