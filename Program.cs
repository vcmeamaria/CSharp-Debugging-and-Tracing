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
            ShowComingSoon("Example 02 - Visual Studio Debugging");
            break;

        case "3":
            ShowComingSoon("Example 03 - Basic Tracing");
            break;

        case "4":
            ShowComingSoon("Example 04 - Debug vs Trace");
            break;

        case "5":
            ShowComingSoon("Example 05 - Debug and Trace Members");
            break;

        case "6":
            ShowComingSoon("Example 06 - Debug.Assert");
            break;

        case "7":
            ShowComingSoon("Example 07 - Conditional Debug");
            break;

        case "8":
            ShowComingSoon("Example 08 - Custom Conditional Logging");
            break;

        case "9":
            ShowComingSoon("Example 09 - Console Trace Listener");
            break;

        case "10":
            ShowComingSoon("Example 10 - File Trace Listener");
            break;

        case "11":
            ShowComingSoon("Example 11 - Trace Configuration");
            break;

        case "12":
            ShowComingSoon("Example 12 - log4net");
            break;

        case "13":
            ShowComingSoon("Example 13 - Logging Levels");
            break;

        case "14":
            ShowComingSoon("Example 14 - Complete Debugging and Tracing Example");
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

static void ShowComingSoon(string exampleName)
{
    Console.WriteLine("==========================================");
    Console.WriteLine(exampleName);
    Console.WriteLine("==========================================");
    Console.WriteLine();

    Console.WriteLine("This example will be added in its own branch.");

    Pause();
}


static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Press Enter to return to the menu...");
    Console.ReadLine();
}