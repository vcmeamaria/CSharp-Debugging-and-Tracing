// ======================================================
// Example 05 - Debug and Trace Members
// ======================================================
//
// Debug and Trace provide several methods for writing
// diagnostic information.
//
// This example focuses on:
//
// - Write()
// - WriteLine()
// - WriteIf()
// - WriteLineIf()
// - Indent()
// - Unindent()
//
// The messages can be viewed in:
// Visual Studio -> Output -> Debug
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet05DebugTraceMembers
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("   EXAMPLE 05 - DEBUG AND TRACE MEMBERS");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Write()
        // --------------------------------------------------
        //
        // Write() outputs text without automatically moving
        // to a new line.
        // --------------------------------------------------

        Debug.Write("Debug.Write: ");
        Debug.Write("same line");

        // Debug.WriteLine() needs a value,
        // so an empty string is used to move to a new line.

        Debug.WriteLine("");


        // --------------------------------------------------
        // WriteLine()
        // --------------------------------------------------
        //
        // WriteLine() writes text and then moves to the
        // next line.
        // --------------------------------------------------

        Debug.WriteLine("Debug.WriteLine: new line");


        // --------------------------------------------------
        // WriteIf()
        // --------------------------------------------------
        //
        // WriteIf() only writes the message if the
        // condition is true.
        // --------------------------------------------------

        int age = 15;

        Debug.WriteIf(age < 18, "Debug.WriteIf: User is under 18");

        // Move to the next line after WriteIf().

        Debug.WriteLine("");


        // --------------------------------------------------
        // WriteLineIf()
        // --------------------------------------------------
        //
        // WriteLineIf() writes the message only if the
        // condition is true, and then starts a new line.
        // --------------------------------------------------

        Trace.WriteLineIf(
            age < 18,
            "Trace.WriteLineIf: User is under 18"
        );


        // --------------------------------------------------
        // Indent()
        // --------------------------------------------------
        //
        // Indent() increases the indentation of following
        // Trace output.
        // --------------------------------------------------

        Trace.WriteLine("Trace output:");

        Trace.Indent();

        Trace.WriteLine("Indented message 1");
        Trace.WriteLine("Indented message 2");


        // --------------------------------------------------
        // Unindent()
        // --------------------------------------------------
        //
        // Unindent() reduces the indentation level again.
        // --------------------------------------------------

        Trace.Unindent();

        Trace.WriteLine("Back to normal indentation");


        // --------------------------------------------------
        // Normal Console Output
        // --------------------------------------------------

        Console.WriteLine("Diagnostic messages have been written.");
        Console.WriteLine();
        Console.WriteLine("Check Visual Studio: Output -> Debug");
    }
}