using System; //references System

namespace NumberGuesser
{
    //Main Class - Program
    class Program
    {
        //Entry Point Method - Main()
        static void Main(string[] args)
        {

            getAppInfo(); //App Name, Version, Author
            greetUser();

            while (true)
            {
                //Initialise Number to guess
                Random random = new Random();
                int hiddenNumber = random.Next(1, 11);

                //Initialise Guess variable
                int guess = 0;

                //User Input for Number
                Console.WriteLine("Guess a number within the range of 1 and 10");


                //Error checking
                while (guess != hiddenNumber)
                {
                    string input = Console.ReadLine();
                    
                    if (!int.TryParse(input, out guess)) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input Error: Only numbers are allowed.");
                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input); 
                    Console.WriteLine("Incorrect! Try again!");
                }


                /* Replayability
                1. Ask to play again? Prompting a Yes or No [Y or N]
                2. Loop back if yes, goodbye message if no!
                 */

                Console.WriteLine("Want to play again? Type Y or N for Yes or No respectively");
                string replayAnswer = Console.ReadLine().ToUpper();

                if (replayAnswer == "Y")
                {
                    Console.WriteLine("Okay! Let's play again!");
                    continue;
                }
                else if (replayAnswer == "N")
                {
                    Console.WriteLine("See you next time!");
                    return;
                }
                else {
                    Console.WriteLine("Input Error: Only Y and N are permitted values");
                }
            }

            static void getAppInfo()
            {
                //App variables
                string appName = "Number Guesser";
                string appVersion = "1.0";
                string appAuthor = "Thomas Nguyen - github.com/nguyentthomas";

                //Output
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
                Console.ResetColor();
            }

            static void greetUser() {
                //Personalised Input - Get User Input
                Console.WriteLine("What is your name?");

                string inputName = Console.ReadLine();

                Console.WriteLine($"Hello {inputName}, come on and let's play!");
            }

        }
    }
}
