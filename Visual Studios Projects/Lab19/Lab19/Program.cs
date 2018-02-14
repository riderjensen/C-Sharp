// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab19
// Date: 3/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab19
{
    static public class Program
    {
        static public void Main()
        {
            //variables
            int dieOne;
            int dieTwo;
            int diceCombined;
            string userInput;
            Random randomNums = new Random();

            WriteLine("Welcome to Rolling Dice!");
            //do-while loop to ask for user input if they want to play
            do
            {
                WriteLine("Would you like to roll the dice?");
                userInput = ReadLine();
                //if input they dont enter y or n, write invalid input and go back to ask them if they want to play
                if (userInput != "n" && userInput != "y")
                {
                    WriteLine("Please try again by inputing either 'y' to play or 'n' to quit. If you enter in another incorrect input, this program will end.");
                    userInput = ReadLine();
                }
                //if input = n, break
                if (userInput == "n"){ break; }
                if (userInput == "y")
                {
                    //if input = y, generate two random numbers
                    dieOne = randomNums.Next(1, 7);
                    dieTwo = randomNums.Next(1, 7);
                    diceCombined = dieOne + dieTwo;
                    //if both dice = 6, display "You rolled box cars"
                    if (dieOne == 6 && dieTwo == 6) { WriteLine("You rolled box cars for a total of " + diceCombined + "!"); }
                    //if both dice = 1, display "You rolled snake eyes"
                    if (dieOne == 1 && dieTwo == 1) { WriteLine("You rolled snake eyes for a total of " + diceCombined + "!"); }
                    //else display dice with "You rolled a " + dieOne + " and a " + dieTwo.
                    if (!(dieOne == 6 && dieTwo == 6) && !(dieOne == 1 && dieTwo == 1)) { WriteLine("You rolled a " + dieOne + " and a " + dieTwo + " for a total of " + diceCombined + "."); }
                }


            } while (userInput == "y");
            

            Write("Press any key to close ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Lab19

