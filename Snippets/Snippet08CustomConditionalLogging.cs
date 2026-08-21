// ======================================================
// Example 08 - Custom Conditional Logging
// ======================================================
//
// We can create our own diagnostic methods and make
// them run only in specific build configurations.
//
// In this example we create:
//
// LogDebug()
//
// The method uses:
//
// [Conditional("DEBUG")]
//
// This means:
//
// DEBUG build
// -> LogDebug() calls are included.
//
// RELEASE build
// -> LogDebug() calls are ignored.
//
// This is useful for creating custom development-only
// logging methods.
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet08CustomConditionalLogging
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("  EXAMPLE 08 - CUSTOM CONDITIONAL LOGGING");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Debug-only logging
        // --------------------------------------------------
        //
        // LogDebug() looks like a normal method call.
        //
        // However, the method has:
        //
        // [Conditional("DEBUG")]
        //
        // so the call only happens in a Debug build.
        // --------------------------------------------------

        LogDebug("Starting calculation");


        // Perform a normal calculation.

        int result = Add(5, 7);


        // Log the result.
        //
        // Again, this message only appears when DEBUG
        // is defined.

        LogDebug($"Result: {result}");


        // Normal console output always runs.

        Console.WriteLine($"Calculation result: {result}");
    }


    // ======================================================
    // Add Method
    // ======================================================

    private static int Add(int a, int b)
    {
        return a + b;
    }


    // ======================================================
    // Custom Debug Logging Method
    // ======================================================
    //
    // Calls to this method are only included when the
    // DEBUG compilation symbol exists.
    // ======================================================

    [Conditional("DEBUG")]
    private static void LogDebug(string message)
    {
        Console.WriteLine($"[DEBUG] {message}");
    }
}