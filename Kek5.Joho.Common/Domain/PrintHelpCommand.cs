using System.Text.Json;
using System.Text.Json.Serialization;
using Kek5.Joho.Common.Enums;
using Kek5.Joho.Common.Interfaces;

namespace Kek5.Joho.Common.Domain;

public class PrintHelpCommand : ICommand
{
    public Commands CommandType { get; set; } = Commands.PrintHelp;

    public OutputFormat OutputFormat { get; set; } = OutputFormat.PlainText;

    public Dictionary<FlagTypes, string> Paramz { get; set; } = new Dictionary<FlagTypes, string>();

    public bool Validate() {
        return true;
    }

    public bool Execute() {
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
