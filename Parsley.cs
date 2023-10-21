using Kek5.Joho.Domain;
using Kek5.Joho.Domain.Interfaces;
using Kek5.Joho.Emums;

namespace Kek5.Joho;

public static class Parsley {

    public static ICommand ParseArguments(string[] args)
    {
        if (args.Length < 2)
        {
            throw new ArgumentException("Not enough arguments provided.");
        }

        var command = args[0].Trim().ToLower();
        var argument = args[1];

        var commandType = command switch
        {
            "get-issue" =>  Commands.GetIssue,              
            _ => Commands.PrintHelp,
        };

        var paramz = BuildParamDict(args);

        var parsedOutput = ParseOutputFormat(paramz);

        if(paramz.ContainsKey(FlagTypes.Output)) { 
            paramz.Remove(FlagTypes.Output);
        }
        
        //use command factory
        return new GetIssueCommand {
            CommandType = commandType,
            Paramz = paramz,
            OutputFormat = parsedOutput 
        };
    }

    private static OutputFormat ParseOutputFormat(Dictionary<FlagTypes, string> paramz)
    {
        if(!paramz.ContainsKey(FlagTypes.Output)) {
            //default
            return OutputFormat.PlainText;
        }

        OutputFormat res = paramz[FlagTypes.Output] switch 
        {
            "json" => OutputFormat.Json,
            "yaml" => OutputFormat.Yaml,
            "yml" => OutputFormat.Yaml,
            "plain" => OutputFormat.PlainText,
            "plainText" => OutputFormat.PlainText,
            _ => OutputFormat.PlainText
        };

        return res;
    }

    private static Dictionary<FlagTypes, string> BuildParamDict(string[] args){

        var flagsInArgs = new Dictionary<string, int> ();
        var paramDict = new Dictionary<FlagTypes, string> ();

        for (var i = 0; i < args.Length; i ++) 
        {
            if(args[i].Contains('-'))
            {
                flagsInArgs.Add(args[i].Trim().ToLower(), i);
            }
        }

        foreach (var (key, value) in flagsInArgs)
        {
            if(!Constants.AVALIABLE_FLAGS.ContainsKey(key))
            {
                continue;
            }

            var atEnd = value >= args.Length - 1;

            if(atEnd) 
            {
                System.Console.WriteLine($"Add a value to your {key} flag");
                continue;
            }

            var flagValue = args[value + 1].Trim().ToLower();

            if(String.IsNullOrWhiteSpace(flagValue))
            {
                continue;
            }

            paramDict.Add(Constants.AVALIABLE_FLAGS[key], flagValue);
        }

        return paramDict;
    }
}
