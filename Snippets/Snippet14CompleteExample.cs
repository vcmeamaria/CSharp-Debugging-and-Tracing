// ======================================================
// Example 14 - Complete Debugging and Tracing Example
// ======================================================
//
// This final example combines several concepts:
//
// - Debug.WriteLine()
// - Debug.Assert()
// - Trace.WriteLine()
// - ConsoleTraceListener
// - TextWriterTraceListener
// - Trace.AutoFlush
// - try / catch
// - DivideByZeroException
//
// Trace messages will be written to:
//
// 1. The console
// 2. trace-log.txt
//
// ======================================================

using System.Diagnostics;
using System.IO;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet14CompleteExample
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine(" EXAMPLE 14 - COMPLETE DEBUGGING & TRACING");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Create Trace Listeners
        // --------------------------------------------------
        //
        // ConsoleTraceListener:
        // Sends Trace messages to the console.
        //
        // TextWriterTraceListener:
        // Sends Trace messages to a text file.
        // --------------------------------------------------

        ConsoleTraceListener consoleListener =
            new ConsoleTraceListener();

        string logFilePath =
            Path.GetFullPath("trace-log.txt");

        TextWriterTraceListener fileListener =
            new TextWriterTraceListener(logFilePath);


        // Add both listeners to Trace.

        Trace.Listeners.Add(consoleListener);
        Trace.Listeners.Add(fileListener);


        // --------------------------------------------------
        // AutoFlush
        // --------------------------------------------------
        //
        // Ensures Trace output is written immediately.
        // --------------------------------------------------

        Trace.AutoFlush = true;


        // --------------------------------------------------
        // Application Starts
        // --------------------------------------------------

        Trace.WriteLine("Application started");


        // --------------------------------------------------
        // Variables
        // --------------------------------------------------

        int number1 = 20;
        int number2 = 0;


        // Debug.WriteLine is mainly used during development.
        //
        // This message appears in Visual Studio's
        // Output -> Debug window.

        Debug.WriteLine("Variables initialized");


        // --------------------------------------------------
        // Try the Calculation
        // --------------------------------------------------

        try
        {
            // ----------------------------------------------
            // Debug.Assert
            // ----------------------------------------------
            //
            // We expect number2 NOT to be zero.
            //
            // But:
            //
            // number2 = 0
            //
            // Therefore:
            //
            // number2 != 0
            //
            // is FALSE.
            //
            // In Debug mode, Visual Studio should report
            // the failed assertion.
            // ----------------------------------------------

            Debug.Assert(
                number2 != 0,
                "number2 must not be zero"
            );


            // ----------------------------------------------
            // Divide
            // ----------------------------------------------
            //
            // If we continue after the assertion,
            // Divide() will attempt:
            //
            // 20 / 0
            //
            // This causes a DivideByZeroException.
            // ----------------------------------------------

            int result = Divide(number1, number2);


            // This line only runs if Divide() succeeds.

            Trace.WriteLine($"Result: {result}");
        }


        // --------------------------------------------------
        // Catch DivideByZeroException
        // --------------------------------------------------
        //
        // This handles the specific divide-by-zero error.
        // --------------------------------------------------

        catch (DivideByZeroException ex)
        {
            Trace.WriteLine(
                $"Divide by zero error: {ex.Message}"
            );

            Console.WriteLine("Cannot divide by zero.");
        }


        // --------------------------------------------------
        // Catch Other Exceptions
        // --------------------------------------------------
        //
        // This catches other unexpected exceptions.
        // --------------------------------------------------

        catch (Exception ex)
        {
            Trace.WriteLine(
                $"General error: {ex.Message}"
            );
        }


        // --------------------------------------------------
        // Application Ends
        // --------------------------------------------------

        Trace.WriteLine("Application ended");

        Console.WriteLine("Program finished");

        Console.WriteLine();
        Console.WriteLine($"Trace file: {logFilePath}");


        // --------------------------------------------------
        // Clean Up Trace Listeners
        // --------------------------------------------------
        //
        // Because this project uses a console menu,
        // remove the listeners when this example finishes.
        //
        // This prevents duplicate listeners if the
        // example is selected again.
        // --------------------------------------------------

        Trace.Flush();

        Trace.Listeners.Remove(consoleListener);
        Trace.Listeners.Remove(fileListener);

        consoleListener.Close();
        fileListener.Close();
    }


    // ======================================================
    // Divide Method
    // ======================================================

    private static int Divide(int a, int b)
    {
        // Record the values received by the method.

        Trace.WriteLine(
            $"Divide method called with a={a}, b={b}"
        );

        return a / b;
    }
}