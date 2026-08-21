// ======================================================
// Example 04 - Debug vs Trace
// ======================================================
//
// C# provides two diagnostic classes:
//
// System.Diagnostics.Debug
// System.Diagnostics.Trace
//
// Debug:
// - Mainly used during development.
// - Debug messages are normally associated with Debug builds.
//
// Trace:
// - Used for diagnostic information while an application runs.
// - Trace messages may also be useful outside development.
//
// Both messages can be viewed in Visual Studio's
// Debug Output window.
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet04DebugVsTrace
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("        EXAMPLE 04 - DEBUG VS TRACE");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Debug
        // --------------------------------------------------
        //
        // Debug.WriteLine() writes diagnostic information
        // mainly intended for development.
        // --------------------------------------------------

        Debug.WriteLine("This message is for debugging");


        // --------------------------------------------------
        // Trace
        // --------------------------------------------------
        //
        // Trace.WriteLine() records diagnostic information
        // about the application while it runs.
        // --------------------------------------------------

        Trace.WriteLine("This message is for tracing");


        // Normal user-facing console output.

        Console.WriteLine("Debug and Trace messages have been written.");
        Console.WriteLine();
        Console.WriteLine("Check Visual Studio: Output -> Debug");
    }
}