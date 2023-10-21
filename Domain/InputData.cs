using Kek5.Joho.Emums;

namespace Kek5.Joho.Domain;

public class InputData {

    public Commands CommandType { get; set; }

    public Dictionary<FlagTypes, string> Paramz { get; set; } = new Dictionary<FlagTypes, string>();

    public OutputFormat OutputFormat { get; set; }
    
}
