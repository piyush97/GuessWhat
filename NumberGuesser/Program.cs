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
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName,appVersion,appAuthor);

            // Reset Text color
            Console.ResetColor();

            // ask users name
            Console.WriteLine("What is your name");

            // Get input
            string name = Console.ReadLine();

            // Greet
            Console.WriteLine("Hello {0} lets play a game", name);

            // init new random number
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            // init Guess Var
            int guess = 0;

            // asking user to guess a number

            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct
            while(guess != correctNumber){
                // get user's input
                string GuessNumber = Console.ReadLine();

                // make sure it's a number
                if (!int.TryParse(GuessNumber, out guess)){
                    // change text color to red because error
                    Console.ForegroundColor = ConsoleColor.Red;

                    // message
                    Console.WriteLine("it's NaN, enter a Number please");

                    // reset color
                    Console.ResetColor();

                    // keep going
                    continue;
                }
                // parsing string to int
                guess = Int32.Parse(GuessNumber);

                // match guess to correct number
                if(guess != correctNumber){
                    // change text color to red because error
                    Console.ForegroundColor = ConsoleColor.Red;

                    // message
                    Console.WriteLine("Wrong Number Guess again");

                    // reset color
                    Console.ResetColor();
                }
            }
            // Output Success Message

            // change text color to red because error
            Console.ForegroundColor = ConsoleColor.Yellow;

            // message
            Console.WriteLine("Voila! Correct Number Guessed");

            // reset color
            Console.ResetColor();
        }
    }
}
