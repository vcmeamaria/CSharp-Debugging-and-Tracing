// ======================================================
// Example 02 - Visual Studio Debugging
// ======================================================
//
// This example is designed to practise Visual Studio's
// debugging tools.
//
// We will use:
//
// - Breakpoints
// - Step Over
// - Step Into
// - Step Out
// - Locals
// - Watch
// - Call Stack
// - Immediate Window
//
// The code itself is intentionally simple so that we can
// focus on learning how the debugger works.
// ======================================================

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet02VisualStudioDebugging
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("   EXAMPLE 02 - VISUAL STUDIO DEBUGGING");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Create two variables
        // --------------------------------------------------
        //
        // While debugging, we can inspect these values using
        // the Locals or Watch windows.
        // --------------------------------------------------

        int a = 10;
        int b = 20;


        // --------------------------------------------------
        // Method Call
        // --------------------------------------------------
        //
        // Place a breakpoint on the line below.
        //
        // Step Over:
        // Runs Add() without entering the method.
        //
        // Step Into:
        // Takes us inside the Add() method.
        // --------------------------------------------------

        int result = Add(a, b);


        // Display the result.

        Console.WriteLine($"First number: {a}");
        Console.WriteLine($"Second number: {b}");
        Console.WriteLine($"Result: {result}");
    }


    // ======================================================
    // Add Method
    // ======================================================
    //
    // Step Into will bring us inside this method.
    //
    // While inside the method:
    //
    // x contains the value from a
    // y contains the value from b
    //
    // Step Out can then finish this method and return
    // to Run().
    // ======================================================

    private static int Add(int x, int y)
    {
        return x + y;
    }
}