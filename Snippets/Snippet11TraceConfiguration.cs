// ======================================================
// Example 11 - Trace Configuration
// ======================================================
//
// Older .NET Framework applications could configure
// tracing using an App.config file.
//
// When the application was compiled, App.config became:
//
// YourApplication.exe.config
//
// The configuration file could define where Trace
// messages should be written.
//
// IMPORTANT:
//
// This project uses modern .NET (.NET 10).
//
// The App.config tracing approach shown in this example
// belongs to older .NET Framework applications.
//
// We are keeping the example here so we can understand
// how this configuration method worked.
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet11TraceConfiguration
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("     EXAMPLE 11 - TRACE CONFIGURATION");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Trace Messages
        // --------------------------------------------------
        //
        // In an older .NET Framework application,
        // App.config could configure a listener for these
        // Trace.WriteLine() messages.
        // --------------------------------------------------

        Trace.WriteLine("Application started");

        Trace.WriteLine(
            "Trace message written using configuration example"
        );

        Trace.WriteLine("Application ended");


        // --------------------------------------------------
        // Modern .NET Note
        // --------------------------------------------------
        //
        // Our project uses .NET 10, so the old App.config
        // tracing configuration is not being used to
        // configure this application.
        //
        // The Trace messages can still be viewed in:
        //
        // Visual Studio -> Output -> Debug
        // --------------------------------------------------

        Console.WriteLine("Trace messages have been written.");
        Console.WriteLine();
        Console.WriteLine("Check Visual Studio: Output -> Debug");
        Console.WriteLine();
        Console.WriteLine(
            "App.config is included as an older .NET Framework example."
        );
    }
}