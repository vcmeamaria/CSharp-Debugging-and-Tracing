// ======================================================
// Example 03 - Basic Tracing
// ======================================================
//
// Tracing records information about what a program is
// doing while it runs.
//
// Trace messages can help us understand:
//
// - When an application starts
// - Which methods are being called
// - What values are being processed
// - What result was produced
//
// Trace is available through:
// System.Diagnostics
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet03BasicTracing
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("        EXAMPLE 03 - BASIC TRACING");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Trace.WriteLine
        // --------------------------------------------------
        //
        // Trace.WriteLine records a diagnostic message.
        //
        // This lets us follow what the application is doing
        // without adding everything to the normal console
        // output.
        // --------------------------------------------------

        Trace.WriteLine("Application started");


        // Call the Add method.

        int result = Add(10, 20);


        // Record the result using Trace.

        Trace.WriteLine($"Result is {result}");


        // This is normal console output.

        Console.WriteLine("Finished");
    }


    // ======================================================
    // Add Method
    // ======================================================

    private static int Add(int a, int b)
    {
        // Record which values are being added.

        Trace.WriteLine($"Adding {a} and {b}");

        return a + b;
    }
}