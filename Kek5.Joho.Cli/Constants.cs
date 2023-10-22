using System.Collections.Immutable;
using Kek5.Joho.Common.Enums;

namespace Kek5.Joho.Cli;

public static class Constants {
    public static readonly ImmutableDictionary<string, FlagTypes> AVALIABLE_FLAGS = ImmutableDictionary.CreateRange(new Dictionary<string, FlagTypes>
            {
            {"-o", FlagTypes.Output},
            {"--output", FlagTypes.Output},
            {"-k", FlagTypes.Key},
            {"--key", FlagTypes.Key},
            {"-p", FlagTypes.Project},
            {"--project", FlagTypes.Project},

            });
}
