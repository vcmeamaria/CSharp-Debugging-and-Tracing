// ======================================================
// Example 12 - Logging with log4net
// ======================================================
//
// log4net is a logging library for .NET applications.
//
// It can write log messages to different destinations,
// including:
//
// - Console
// - Files
// - Rolling files
// - Databases
// - Event logs
//
// In this example, log4net.config sends messages to:
//
// 1. The console
// 2. application.log
//
// ======================================================

using System.IO;
using System.Reflection;

using log4net;
using log4net.Config;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet12Log4Net
{
    // ==================================================
    // Logger
    // ==================================================
    //
    // ILog represents our logger.
    //
    // GetLogger() creates a logger associated with this
    // class.
    // ==================================================

    private static readonly ILog log =
        LogManager.GetLogger(typeof(Snippet12Log4Net));


    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("          EXAMPLE 12 - LOG4NET");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Get the log4net repository
        // --------------------------------------------------
        //
        // The repository stores log4net's configuration
        // and logging information.
        // --------------------------------------------------

        var logRepository =
            LogManager.GetRepository(
                Assembly.GetEntryAssembly()!
            );


        // --------------------------------------------------
        // Configure log4net
        // --------------------------------------------------
        //
        // log4net.config defines where the log messages
        // should be written and how they should look.
        // --------------------------------------------------

        XmlConfigurator.Configure(
            logRepository,
            new FileInfo("log4net.config")
        );


        // --------------------------------------------------
        // Log messages
        // --------------------------------------------------
        //
        // log4net supports different logging levels.
        // --------------------------------------------------

        log.Debug("Debug message");

        log.Info("Application started");

        log.Warn("This is a warning");


        // --------------------------------------------------
        // Exception Logging
        // --------------------------------------------------
        //
        // We deliberately divide by zero here.
        //
        // The exception is caught and recorded using
        // log.Error().
        // --------------------------------------------------

        try
        {
            int result = Divide(10, 0);

            log.Info($"Result: {result}");
        }
        catch (Exception ex)
        {
            log.Error(
                "An error occurred while dividing numbers",
                ex
            );
        }


        log.Info("Application ended");


        Console.WriteLine();
        Console.WriteLine("Check application.log for the file output.");
    }


    // ======================================================
    // Divide Method
    // ======================================================

    private static int Divide(int a, int b)
    {
        // Record some technical information before
        // performing the calculation.

        log.Debug($"Dividing {a} by {b}");

        return a / b;
    }
}