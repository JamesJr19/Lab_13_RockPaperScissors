using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RockPaperScissors
{
    class RandomBot : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random r = new Random();
            int randomChoice = r.Next(0, 3);
            Roshambo[] choices = { Roshambo.Rock, Roshambo.Paper, Roshambo.Scissors };
            Roshambo randomSelection = choices[randomChoice];
            return randomSelection;
        }

        public void printRoshambo()
        {
            Roshambo botChoice = GenerateRoshambo();
            Console.WriteLine(botChoice);

        }
    }
}
