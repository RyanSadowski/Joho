using Kek5.Joho.Domain;
using Kek5.Joho.Domain.Interfaces;

namespace Kek5.Joho.Factories.Interfaces;

public interface ICommandFactory {
    public ICommand CreateCommand(InputData data);
}
