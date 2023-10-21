using Kek5.Joho.Domain;
using Kek5.Joho.Domain.Interfaces;
using Kek5.Joho.Emums;
using Kek5.Joho.Factories.Interfaces;

namespace Kek5.Joho.Factories;

public class CommandFactory : ICommandFactory {
    public CommandFactory () {

    }

    public ICommand CreateCommand(InputData data)
    {
        ICommand command = data.CommandType switch {
            Commands.GetIssue => new GetIssueCommand {
                CommandType = data.CommandType,
                Paramz = data.Paramz,
                OutputFormat = data.OutputFormat
            },
            Commands.PrintHelp => new PrintHelpCommand {
                CommandType = data.CommandType,
                Paramz = data.Paramz,
                OutputFormat = data.OutputFormat
            },
            _ => new PrintHelpCommand {
                CommandType = data.CommandType,
                Paramz = data.Paramz,
                OutputFormat = data.OutputFormat
            }
        };

        return command;
    }
}
