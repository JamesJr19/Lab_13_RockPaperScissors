using System;

namespace Lab_13_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's play Rock, Paper, Scissors.");
            Console.WriteLine("Select an opponent to play:");
            Console.WriteLine($"1. Leonard Washington\n2. Ashy Larry\n 3. Quit");

            bool tryAgain = true;
            while (tryAgain)
            {
                string userSelected = Console.ReadLine().ToLower();
                tryAgain = false;



                switch (userSelected)
                {
                    case "1":
                    case "rockbot":
                        FightRockBot();
                        break;

                    case "2":
                    case "randombot":
                        FightRandomBot();
                        break;

                    case "3":
                    case "quit":
                        Console.WriteLine("Don't be a poor sport!");
                        Environment.Exit(0);
                        break;
                    default:
                        tryAgain = true;
                        Console.WriteLine("Invalid. Try another option");
                        break;



                        
                }
            }
        }



        public static void FightRockBot()
        {
            
        }

        public static void FightRandomBot()
        {

        }

        public static string GetUserInput(string message)
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
