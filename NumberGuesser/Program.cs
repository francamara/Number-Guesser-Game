using System;


// Namespace
namespace NumberGuesser
{   // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {


            GetAppInfo();

            GreetUser();

            // GAME CODE STARTS HERE //

            while (true)
            {

            // Init  correct number
            // Create a random object 
            Random random = new Random();

            int correctNumber = random.Next(1, 11);

            // Init guess var 
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            // While guess not true, then ask user again
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Check is a number 

                if(!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("{0} is not a number asshole, try again", input);

                    Console.ResetColor();

                    // Keep the code going

                    continue;
                }

                //  Cast to int and put in guess variable

                guess = Int32.Parse(input);

                // Match guess to correct number

                if( guess != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }
            }

            // Output  success message
            PrintColorMessage(ConsoleColor.Yellow, "You guessed! GGWP");

                // Ask user to play again
                Console.WriteLine("Wanna play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
               continue;
            } 
            else if (answer == "N")
            {
                 return;
            }
            else
            {
              return;
            }

            }
        }

        static void GetAppInfo()
        {

            // Console color change (only for title)
            Console.ForegroundColor = ConsoleColor.Green;

            // Set apps vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Fran Camara Dev";

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset console text color
            Console.ResetColor();
        }
        
        static void GreetUser()
        {
                        // Ask users name
            Console.Write("Enter you name: ");

            // Save input into a string

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }
        
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
