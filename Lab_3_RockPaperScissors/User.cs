using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RockPaperScissors
{
    class User : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            GetUserInput("Would you like 1. Rock\nPaper\nScissors?");


        }

        public static string GetUserInput(string message)
        {
            string input = Console.ReadLine();
            return input;
        }

    }
}
