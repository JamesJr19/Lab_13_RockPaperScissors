using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RockPaperScissors
{
    abstract class Player 
    {

       
        public string Name { get; set; }
        public Roshambo Choice { get; set; }


        public abstract Roshambo GenerateRoshambo();
       

    }
}
