using Kek5.Joho.Common.Enums;

namespace Kek5.Joho.Common.Domain;

public class InputData {

    public Commands CommandType { get; set; }

    public Dictionary<FlagTypes, string> Paramz { get; set; } = new Dictionary<FlagTypes, string>();

    public OutputFormat OutputFormat { get; set; }
    
}
