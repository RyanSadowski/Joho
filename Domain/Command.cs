using System.Text.Json;
using System.Text.Json.Serialization;
using Kek5.Joho.Emums;

namespace Kek5.Joho.Domain;

public class Command 
{
    public Commands CommandType { get; set; }

    public OutputFormat OutputFormat { get; set; } = OutputFormat.PlainText;

    public Dictionary<FlagTypes, string> Params { get; set; } = new Dictionary<FlagTypes, string>();

    public void Print() {

        var options = new JsonSerializerOptions
        {
            WriteIndented = true, // For pretty-printing
            Converters = { new JsonStringEnumConverter() } // Serialize enums as strings
        };
        
        string jsonString = JsonSerializer.Serialize(Params, options);

        System.Console.WriteLine($"Command : {CommandType}");
        System.Console.WriteLine($"Params : {jsonString}");
        System.Console.WriteLine($"Output Format: {OutputFormat}");
    }
}
