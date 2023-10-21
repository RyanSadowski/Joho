using Kek5.Joho.Emums;

namespace Kek5.Joho;

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
