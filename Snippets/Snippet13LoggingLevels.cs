// ======================================================
// Example 13 - log4net Logging Levels
// ======================================================
//
// log4net provides different logging levels.
//
// Each level describes how important or serious
// a log message is.
//
// The levels used in this example are:
//
// DEBUG
// -> Detailed technical information.
//
// INFO
// -> General application progress.
//
// WARN
// -> Something unexpected, but not fatal.
//
// ERROR
// -> An operation has failed.
//
// FATAL
// -> A serious failure that could cause the
//    application to shut down.
//
// ======================================================

using System.IO;
using System.Reflection;

using log4net;
using log4net.Config;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet13LoggingLevels
{
    // ==================================================
    // Logger
    // ==================================================

    private static readonly ILog log =
        LogManager.GetLogger(typeof(Snippet13LoggingLevels));


    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("      EXAMPLE 13 - LOGGING LEVELS");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Configure log4net
        // --------------------------------------------------
        //
        // We use the same log4net.config file created in
        // Example 12.
        //
        // The configuration sends messages to:
        //
        // - The console
        // - application.log
        // --------------------------------------------------

        var logRepository =
            LogManager.GetRepository(
                Assembly.GetEntryAssembly()!
            );

        XmlConfigurator.Configure(
            logRepository,
            new FileInfo("log4net.config")
        );


        // --------------------------------------------------
        // DEBUG
        // --------------------------------------------------
        //
        // Used for detailed technical information that is
        // useful while developing or diagnosing a program.
        // --------------------------------------------------

        log.Debug("Database connection string loaded");


        // --------------------------------------------------
        // INFO
        // --------------------------------------------------
        //
        // Used for normal application progress.
        // --------------------------------------------------

        log.Info("User logged in");


        // --------------------------------------------------
        // WARN
        // --------------------------------------------------
        //
        // Used when something unexpected happens but the
        // application can still continue.
        // --------------------------------------------------

        log.Warn("Password will expire soon");


        // --------------------------------------------------
        // ERROR
        // --------------------------------------------------
        //
        // Used when an operation fails.
        // --------------------------------------------------

        log.Error("Could not save record");


        // --------------------------------------------------
        // FATAL
        // --------------------------------------------------
        //
        // Used for a very serious failure.
        //
        // In a real application, this level could describe
        // a problem serious enough to cause shutdown.
        //
        // For this learning example, we only log the
        // message so our console menu can continue.
        // --------------------------------------------------

        log.Fatal("Application cannot start");


        Console.WriteLine();
        Console.WriteLine("All logging levels have been demonstrated.");
        Console.WriteLine();
        Console.WriteLine("Check application.log for the file output.");
    }
}