using Microsoft.Extensions.Logging;

namespace Logging;
internal partial class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        //Console.WriteLine("Hello, World!");
        //LogStartupMessage(logger, "fun");
        logger.LogCritical("this is a log");
    }

    [LoggerMessage(Level = LogLevel.Information, Message = "Hello World! Logging is {Description}.")]
    static partial void LogStartupMessage(ILogger logger, string description);
}