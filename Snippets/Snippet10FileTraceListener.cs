// ======================================================
// Example 10 - Logging Trace Output to a File
// ======================================================
//
// Trace messages can be written to a file instead of
// only appearing in Visual Studio or the console.
//
// In this example we use:
//
// TextWriterTraceListener
//
// The listener writes Trace messages into:
//
// app-log.txt
//
// This allows us to keep a record of what happened
// while the application was running.
// ======================================================

using System.Diagnostics;
using System.IO;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet10FileTraceListener
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("    EXAMPLE 10 - FILE TRACE LISTENER");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Create the log file path
        // --------------------------------------------------
        //
        // The file will be called:
        //
        // app-log.txt
        //
        // GetFullPath() lets us display exactly where
        // the file was created.
        // --------------------------------------------------

        string logFilePath = Path.GetFullPath("app-log.txt");


        // --------------------------------------------------
        // Create a File Trace Listener
        // --------------------------------------------------
        //
        // TextWriterTraceListener sends Trace messages
        // into a text file.
        // --------------------------------------------------

        TextWriterTraceListener fileListener =
            new TextWriterTraceListener(logFilePath);


        // Add the listener to Trace.

        Trace.Listeners.Add(fileListener);


        // --------------------------------------------------
        // AutoFlush
        // --------------------------------------------------
        //
        // AutoFlush ensures that Trace output is written
        // to the file immediately.
        // --------------------------------------------------

        Trace.AutoFlush = true;


        // --------------------------------------------------
        // Write Trace Messages
        // --------------------------------------------------

        Trace.WriteLine("Application started");

        Trace.WriteLine($"Started at: {DateTime.Now}");


        // --------------------------------------------------
        // Try the operation
        // --------------------------------------------------

        try
        {
            int result = Divide(10, 2);

            Trace.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            // If something goes wrong, record the error
            // message in the log file.

            Trace.WriteLine($"Error: {ex.Message}");
        }


        Trace.WriteLine("Application ended");


        // --------------------------------------------------
        // Finish with the listener
        // --------------------------------------------------
        //
        // Because this is a menu-based project, we remove
        // the listener after the example finishes.
        //
        // This prevents the listener staying active when
        // another example is selected.
        // --------------------------------------------------

        Trace.Flush();

        Trace.Listeners.Remove(fileListener);

        fileListener.Close();


        // Normal console output.

        Console.WriteLine("Trace log created successfully.");
        Console.WriteLine();
        Console.WriteLine($"File: {logFilePath}");
    }


    // ======================================================
    // Divide Method
    // ======================================================

    private static int Divide(int a, int b)
    {
        // Record the values used by the method.

        Trace.WriteLine($"Dividing {a} by {b}");

        return a / b;
    }
}