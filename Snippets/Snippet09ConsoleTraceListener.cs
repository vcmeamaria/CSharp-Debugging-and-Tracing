// ======================================================
// Example 09 - Console Trace Listener
// ======================================================
//
// Trace messages do not have to stay only in Visual
// Studio's Debug Output window.
//
// A Trace Listener decides where Trace messages are sent.
//
// In this example, we use:
//
// ConsoleTraceListener
//
// This sends Trace.WriteLine() messages to the console.
//
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet09ConsoleTraceListener
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("   EXAMPLE 09 - CONSOLE TRACE LISTENER");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Create a Console Trace Listener
        // --------------------------------------------------
        //
        // This listener sends Trace messages directly
        // to the console.
        // --------------------------------------------------

        ConsoleTraceListener consoleListener =
            new ConsoleTraceListener();


        // Add the listener to Trace.

        Trace.Listeners.Add(consoleListener);


        // --------------------------------------------------
        // Write Trace Messages
        // --------------------------------------------------

        Trace.WriteLine("Application started");

        Trace.WriteLine("Performing operation...");


        // Call the Add method.

        int result = Add(10, 30);


        // Record the result.

        Trace.WriteLine($"Result: {result}");


        // --------------------------------------------------
        // Flush
        // --------------------------------------------------
        //
        // Flush() makes sure any buffered Trace output
        // is written immediately.
        // --------------------------------------------------

        Trace.Flush();


        // Normal console output.

        Console.WriteLine("Done");


        // --------------------------------------------------
        // Remove the listener
        // --------------------------------------------------
        //
        // Because this project uses a menu, the example
        // could be selected more than once.
        //
        // Removing the listener prevents duplicate Trace
        // output if the example runs again.
        // --------------------------------------------------

        Trace.Listeners.Remove(consoleListener);

        consoleListener.Close();
    }


    // ======================================================
    // Add Method
    // ======================================================

    private static int Add(int a, int b)
    {
        // This Trace message also goes to the console
        // because the ConsoleTraceListener is active.

        Trace.WriteLine($"Adding {a} and {b}");

        return a + b;
    }
}