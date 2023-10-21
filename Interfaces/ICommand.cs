using Kek5.Joho.Emums;

namespace Kek5.Joho.Domain.Interfaces;

public interface ICommand {

    public Commands CommandType { get; set; }

    public Dictionary<FlagTypes, string> Paramz { get; set; }

    public OutputFormat OutputFormat { get; set; }

    public void Print();

    public bool Validate();

    public bool Execute();
}
