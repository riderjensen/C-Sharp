// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab18
// Date: 3/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab18
{

    static public class Program
    {
        

        static public void Main()
        {
            //variables
            //do-while loop to ask for user input if they want to play
                //if input they dont enter y or n, write invalid input and go back to ask them if they want to play
                //if input = y, generate two random numbers
                    //if both dice = 6, display "You rolled box cars"
                    //if both dice = 1, display "You rolled snake eyes"
                    //else display dice with "You rolled a " + dieOne + " and a " + dieTwo.
                //if input = n, break

            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Lab18

