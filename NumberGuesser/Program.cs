using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Guess It";
            string appVersion = "1.0.0";
            string appAuthor = "Piyush Mehta";

            // Change in TextColor
            Console.ForegroundColor = ConsoleColor.Red;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName,appVersion,appAuthor);

            // Reset Text color
            Console.ResetColor();
        }
    }
}
