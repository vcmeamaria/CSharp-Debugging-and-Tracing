using CSharp_Debugging_and_Tracing.Snippets;

// ======================================================
// C# Debugging and Tracing
// Main Console Menu
// ======================================================

bool keepRunning = true;

while (keepRunning)
{
    Console.Clear();

    Console.WriteLine("==========================================");
    Console.WriteLine("       C# DEBUGGING AND TRACING");
    Console.WriteLine("==========================================");
    Console.WriteLine();

    Console.WriteLine("Choose an example:");
    Console.WriteLine();

    Console.WriteLine("1.  Debugging Basics");
    Console.WriteLine("2.  Visual Studio Debugging");
    Console.WriteLine("3.  Basic Tracing");
    Console.WriteLine("4.  Debug vs Trace");
    Console.WriteLine("5.  Debug and Trace Members");
    Console.WriteLine("6.  Debug.Assert");
    Console.WriteLine("7.  Conditional Debug");
    Console.WriteLine("8.  Custom Conditional Logging");
    Console.WriteLine("9.  Console Trace Listener");
    Console.WriteLine("10. File Trace Listener");
    Console.WriteLine("11. Trace Configuration");
    Console.WriteLine("12. log4net");
    Console.WriteLine("13. Logging Levels");
    Console.WriteLine("14. Complete Debugging and Tracing Example");
    Console.WriteLine();

    Console.WriteLine("0. Exit");
    Console.WriteLine();

    Console.Write("Enter your choice: ");

    string? choice = Console.ReadLine();

    Console.Clear();

    switch (choice)
    {
        case "1":
            Snippet01DebuggingBasics.Run();
            Pause();
            break;

        case "2":
            Snippet02VisualStudioDebugging.Run();
            Pause();
            break;

        case "3":
            Snippet03BasicTracing.Run();
            Pause();
            break;

        case "4":
            Snippet04DebugVsTrace.Run();
            Pause();
            break;

        case "5":
            Snippet05DebugTraceMembers.Run();
            Pause();
            break;

        case "6":
            Snippet06DebugAssert.Run();
            Pause();
            break;

        case "7":
            Snippet07ConditionalDebug.Run();
            Pause();
            break;

        case "8":
            Snippet08CustomConditionalLogging.Run();
            Pause();
            break;

        case "9":
            Snippet09ConsoleTraceListener.Run();
            Pause();
            break;

        case "10":
            Snippet10FileTraceListener.Run();
            Pause();
            break;

        case "11":
            Snippet11TraceConfiguration.Run();
            Pause();
            break;

        case "12":
            Snippet12Log4Net.Run();
            Pause();
            break;

        case "13":
            Snippet13LoggingLevels.Run();
            Pause();
            break;

        case "14":
            Snippet14CompleteExample.Run();
            Pause();
            break;

        case "0":
            Console.WriteLine("Goodbye!");
            keepRunning = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            Console.WriteLine();
            Console.WriteLine("Please choose a number from 0 to 14.");
            Pause();
            break;
    }
}


// ======================================================
// Helper Methods
// ======================================================


static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Press Enter to return to the menu...");
    Console.ReadLine();
}