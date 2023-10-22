using Kek5.Joho.Common.Domain;
using Kek5.Joho.Common.Enums;
using Kek5.Joho.Common.Interfaces;

namespace Kek5.Joho.Common.Factories;

public class CommandFactory : ICommandFactory
{

    private IJiraGateway? _jiraGateway;
    
    public CommandFactory (IJiraGateway? jiraGateway)
    {
        _jiraGateway = jiraGateway;
    }

    public ICommand CreateCommand(InputData data)
    {
        ICommand command = data.CommandType switch {
            Commands.GetIssue => new GetIssueCommand(_jiraGateway, data),
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
