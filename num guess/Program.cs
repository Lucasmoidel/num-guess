using System;

namespace NumGuess
{
    class Program
    {
        static void Main(string[] args)
        {

            AppInfo();

            Greet();
            while (true) {
                //int correct_nuber = 69;
                Random random = new Random();
                int correct_nuber = random.Next(1, 100);
                int guess = 0;

                while (guess != correct_nuber)
                {
                    Console.WriteLine("guess a number between 1 and 100");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        ConsoleColorMessage(ConsoleColor.Red, "that was not a number");

                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess == correct_nuber)
                    {
                        ConsoleColorMessage(ConsoleColor.Green, "you did it!!!!");

                    }
                    else if (guess <= correct_nuber)
                    {
                        ConsoleColorMessage(ConsoleColor.Red, "you were too low");

                    }
                    else if (guess >= correct_nuber)
                    {
                        ConsoleColorMessage(ConsoleColor.Red, "you were too high");
                    }
                }

                Console.WriteLine("would you likw to play again [y or n]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
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
        static void AppInfo()
        {
            string app_version = "0.1";
            string app_namee = "number guess";
            string app_author = "Lucas Moidel";

            // change color

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} {1} by {2}", app_namee, app_version, app_author);
            Console.ResetColor();
        }
        static void Greet()
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("hello {0} do you want to play a game...", name);
        }
        static void ConsoleColorMessage(ConsoleColor color, string messige)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(messige);
            Console.ResetColor();

        }
    }
}