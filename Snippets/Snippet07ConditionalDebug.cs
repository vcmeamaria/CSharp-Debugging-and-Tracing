// ======================================================
// Example 07 - Conditional Debug
// ======================================================
//
// The Conditional attribute allows a method call to be
// included only when a specific compilation symbol exists.
//
// In this example we use:
//
// [Conditional("DEBUG")]
//
// This means:
//
// DEBUG build
// -> The method call is included.
//
// RELEASE build
// -> The method call is ignored.
//
// This is useful for development-only diagnostic methods.
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet07ConditionalDebug
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("       EXAMPLE 07 - CONDITIONAL DEBUG");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Conditional Method Call
        // --------------------------------------------------
        //
        // This looks like a normal method call.
        //
        // However, DebugMessage() has:
        //
        // [Conditional("DEBUG")]
        //
        // above it.
        //
        // Therefore the call only happens when DEBUG
        // is defined.
        // --------------------------------------------------

        DebugMessage("Application started");


        // This normal Console.WriteLine is not conditional,
        // so it will run in both Debug and Release builds.

        Console.WriteLine("Running program...");
    }


    // ======================================================
    // Debug-Only Method
    // ======================================================
    //
    // The Conditional attribute tells the compiler:
    //
    // Only include calls to this method when the DEBUG
    // symbol is defined.
    // ======================================================

    [Conditional("DEBUG")]
    private static void DebugMessage(string message)
    {
        Console.WriteLine($"DEBUG: {message}");
    }
}