// ======================================================
// Example 06 - Debug.Assert
// ======================================================
//
// Assert checks whether a condition is true.
//
// If the condition is true:
// -> The program continues normally.
//
// If the condition is false:
// -> An assertion message is produced.
//
// Assertions are useful for checking assumptions during
// development.
//
// Example:
//
// If a balance should never be negative:
//
// Debug.Assert(balance >= 0);
//
// We are saying:
//
// "I expect balance >= 0 to always be true."
//
// ======================================================

using System.Diagnostics;

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet06DebugAssert
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("          EXAMPLE 06 - DEBUG.ASSERT");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // --------------------------------------------------
        // Create an invalid value
        // --------------------------------------------------
        //
        // In this example, we assume that a balance should
        // never be negative.
        //
        // However, the value below breaks that assumption.
        // --------------------------------------------------

        int balance = -100;

        Console.WriteLine($"Balance: {balance}");
        Console.WriteLine();


        // --------------------------------------------------
        // Debug.Assert
        // --------------------------------------------------
        //
        // The condition is:
        //
        // balance >= 0
        //
        // Our current balance is -100.
        //
        // Therefore:
        //
        // -100 >= 0
        //
        // is FALSE.
        //
        // Because the assertion is false, Visual Studio
        // will produce an assertion message.
        // --------------------------------------------------

        Debug.Assert(
            balance >= 0,
            "Balance should not be negative"
        );


        // --------------------------------------------------
        // Program continues
        // --------------------------------------------------
        //
        // An assertion is mainly a development diagnostic.
        //
        // It helps us identify an assumption that has been
        // broken while testing or debugging the program.
        // --------------------------------------------------

        Console.WriteLine("Application continues...");
    }
}