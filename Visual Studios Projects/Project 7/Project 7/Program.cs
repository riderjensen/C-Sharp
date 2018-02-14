// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Project_7
// Date: 3/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Project_7
{
    static public class Program
    {
        static public void Main()
        {
            //variables
            int months = 1;
            int adults = 1;
            int babies = 0;
            int total;
            //display
            WriteLine("This project is by:");
            WriteLine("Rider Jensen");
            WriteLine("CS 1400-001");
            WriteLine("Month\tAdults\tBabies\tTotal");
            //creating loop
            for (adults = 1; adults < 500; months++)
            {
                //marking total
                total = babies + adults;
                //display each line of the tables
                WriteLine(months + "\t" + adults + "\t" + babies + "\t" + total);
                //increase babies
                babies = adults;
                //increase adults
                adults = total;

            }
            //fixing initialization of months starting at 0
            months = months - 1;
            //display answer
            WriteLine("It will take " + months + " months to fill up the cages.");
            //close program
            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Project_7

