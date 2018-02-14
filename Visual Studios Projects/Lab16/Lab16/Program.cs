// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab16
// Date: 3/7/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab16
{
    static public class Program
    {
        static public void Main()
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";

            // declare a variable to hold user's input
            string today;
            int temperature;

            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();


            // see if it is a work day
            if (today != SUN && today != SAT)
            {
                Console.Write("Please enter the termperature, e.g. 54: ");
                temperature = int.Parse(Console.ReadLine());
                if (temperature > 32) { Console.WriteLine("You have to go to work today..."); }
                else {
                    Console.WriteLine("You have to go to work today and dress warmly!");
                    
                }
                Write("Press any key to continue ... ");
                ReadKey(true); 
            }

            else
            {
                // its not a workday, display the weekend message
                Console.WriteLine("Ahh... the weekend. No work!");
                Write("Press any key to continue ... ");
                ReadKey(true);
            }
            /*
             * Questions:
             * 1. This evaluates to true because, even though we dont know what X is, 
             * the first part of the OR statement evaluated to true so the statement will be true no matter what x is. 
             * 2. This evaluates true too because the first part of the statement is false but 2 is less than the max const
             * so the whole thing evaluates to true.
             */ 
            
        }
    }
}

