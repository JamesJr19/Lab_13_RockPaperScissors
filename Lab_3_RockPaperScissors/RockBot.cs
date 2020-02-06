using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_RockPaperScissors
{
    class RockBot : Player
    {
       
public override Roshambo GenerateRoshambo()
        {
            
            return Roshambo.Rock;
        }
    }
}
