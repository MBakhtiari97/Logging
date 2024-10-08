﻿using Microsoft.Extensions.Logging;

namespace Logging;
internal partial class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        //Console.WriteLine("Hello, World!");
        //LogStartupMessage(logger, "fun");
        //logger.LogInformation("this is a log");
        //logger.LogWarning("this is a log");
        //logger.LogCritical("this is a log");
        // logger.LogError("this is a log");
        logger.Log(LogLevel.Information, "Hello Log {0}", "Service");
    }

    [LoggerMessage(Level = LogLevel.Information, Message = "Hello World! Logging is {Description}.")]
    static partial void LogStartupMessage(ILogger logger, string description);
}