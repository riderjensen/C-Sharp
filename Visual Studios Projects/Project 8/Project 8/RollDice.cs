using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_8
{
    class RollDice
    {
        //random numbers
        Random randomNums = new Random();
        //dice one ref method
        //Input: dice one - a 0 for placeholder
        //output: a random number assigned to that variable now
        public int RollingDiceOne(ref int diceOne)
        {
            diceOne = randomNums.Next(1, 7);
            return diceOne;

        }
        //dice two ref method
        //Input: dice two - a 0 for placeholder
        //output: a random number assigned to that variable now
        public int RollingDiceTwo(ref int diceTwo)
        {
            diceTwo = randomNums.Next(1, 7);
            return diceTwo;
        }


    }
}
