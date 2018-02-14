// File/Project Prolog
// Name: Rider Jensen
// CS 1400-001
// Project: Lab20
// Date: 3/28/2017
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab20
{
    static public class Program
    {
        static public void Main()
        {
            int number1 = 10;
            int number2 = 15;

            // call the Swap method and output the result
            Swap(ref number1, ref number2);
            WriteLine($"number1 = {number1:D}");
            WriteLine($"number2 = {number2:D}");

            ReadKey(true);
        }

        // The Swap method
        // Purpose: To interchange the value of two variables
        // Parameters: two integers
        // Returns: None
        // Pre-conditions: None
        // Post-conditions: None
        // Side Effect: the values of the 2 integers are swapped

        static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

        }

           
   }
}

