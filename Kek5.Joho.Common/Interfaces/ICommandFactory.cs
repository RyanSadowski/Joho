using Kek5.Joho.Common.Domain;

namespace Kek5.Joho.Common.Interfaces;

public interface ICommandFactory
{
    ICommand CreateCommand(InputData inputData);

}