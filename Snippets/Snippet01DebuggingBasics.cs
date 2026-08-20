// ======================================================
// Example 01 - Debugging Basics
// ======================================================
//
// Debugging is the process of finding, understanding,
// and fixing problems in a program.
//
// A bug might be:
//
// 1. A runtime error
//    -> The program encounters an error while running.
//
// 2. A logic error
//    -> The program runs, but produces the wrong result.
//
// This example demonstrates both types of bugs.
// ======================================================

namespace CSharp_Debugging_and_Tracing.Snippets;

public static class Snippet01DebuggingBasics
{
    public static void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("       EXAMPLE 01 - DEBUGGING BASICS");
        Console.WriteLine("==========================================");
        Console.WriteLine();


        // ==================================================
        // PART 1 - Runtime Error
        // ==================================================
        //
        // The example below is based on dividing a number
        // by zero.
        //
        // Dividing an integer by zero causes a:
        //
        // DivideByZeroException
        //
        // Normally, this would stop the program.
        // We use try/catch here so that our learning menu
        // can continue running after demonstrating the error.
        // ==================================================

        Console.WriteLine("PART 1 - Runtime Error");
        Console.WriteLine();

        int total = 10;
        int count = 0;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Count: {count}");
        Console.WriteLine();

        try
        {
            int average = total / count;

            Console.WriteLine($"Average: {average}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("ERROR: A number cannot be divided by zero.");
            Console.WriteLine("This caused a DivideByZeroException.");
        }


        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();


        // ==================================================
        // PART 2 - Logic Error
        // ==================================================
        //
        // Logic errors are different.
        //
        // The program still runs, but the result is wrong.
        //
        // If adulthood begins at age 18, this condition:
        //
        //     age > 18
        //
        // would incorrectly treat an 18-year-old as a minor.
        //
        // The correct condition is:
        //
        //     age >= 18
        //
        // ==================================================

        Console.WriteLine("PART 2 - Logic Error");
        Console.WriteLine();

        int age = 18;

        Console.WriteLine($"Age: {age}");
        Console.WriteLine();


        // --------------------------------------------------
        // Incorrect condition
        // --------------------------------------------------

        Console.WriteLine("Using the incorrect condition: age > 18");

        if (age > 18)
        {
            Console.WriteLine("Result: Adult");
        }
        else
        {
            Console.WriteLine("Result: Minor");
        }


        Console.WriteLine();


        // --------------------------------------------------
        // Correct condition
        // --------------------------------------------------

        Console.WriteLine("Using the correct condition: age >= 18");

        if (age >= 18)
        {
            Console.WriteLine("Result: Adult");
        }
        else
        {
            Console.WriteLine("Result: Minor");
        }

    }
}