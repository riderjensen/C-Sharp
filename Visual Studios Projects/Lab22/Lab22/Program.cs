// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 01
// Project: Lab22
// Date: 4/4/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab22
{
    static public class Program
    {
        static public void Main()
        {
            //creating the array
            const int SIZE = 10;
            int[] arrayWork = new int[SIZE];
            int numberOfTimes = 0;

            WriteLine("Please enter in 10 values one at a time to fill the array");
            //getting user input for array values
            for (int i = 0; i < SIZE; i++)
            {
                WriteLine("You have entered in {0} value(s)", numberOfTimes);
                arrayWork[i] = int.Parse(ReadLine());
                numberOfTimes++;
            }
            WriteLine("The total amount you entered is equal to {0}", sumArray(arrayWork));
            
            WriteLine("Press any key to continue ... ");
            ReadKey(true);
        }

        //The sumArray
        //Purpose: Add all the elements in the array and print the sum
        //Input: Values in an array
        //Output: The sum of the array values
        static int sumArray(int[] arrayWork)
        {
            int sumTotal = 0;
            foreach (int value in arrayWork)
            {
                sumTotal += value;
            }
            return sumTotal;
        }
    }//End class Program
}//End namespace Lab22

