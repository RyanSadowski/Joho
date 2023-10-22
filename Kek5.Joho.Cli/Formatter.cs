using Kek5.Joho.Common.Enums;

namespace Kek5.Joho.Cli;

public static class Formatter {
    

    public static string Format(OutputFormat format, String data) {

        return format switch
        {
            OutputFormat.PlainText => FormatPlainTextData(data),
            _ => "Rip", 
        };

    }

    public static string FormatPlainTextData(string data) {

        return data;
    }
}
