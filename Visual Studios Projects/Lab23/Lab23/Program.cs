// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 01
// Project: Lab23
// Date: 4/6/2017 
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab23
{
    static public class Program
    {
        static public void Main()
        { //creating the array
            const int SIZE = 100;
            int[] arrayWork = new int[SIZE];
            int counter = 0;
            int counterPlus1 = 1;

            WriteLine("Please enter in values one at a time to fill the array. Enter 0 at any time to stop filling the array.");
            //getting user input for array values
            arrayWork[counter] = int.Parse(ReadLine());
            while ((arrayWork[counter] != 0) && (counter != SIZE))
            {
                WriteLine("You have entered in {0} value(s)", counterPlus1);
                counter++;
                counterPlus1++;
                int temp = int.Parse(ReadLine());
                if (temp == 0)
                {
                    temp = 1;
                    break;
                }
                arrayWork[counter] = temp;
            }
            WriteLine("The total amount you entered is equal to {0}", multArray(arrayWork, counter));

            WriteLine("Press any key to continue ... ");
            ReadKey(true);
        }

        //The multArray
        //Purpose: Multiply all the elements in the array and print the sum
        //Input: Values in an array
        //Output: The product of the array values
        static int multArray(int[] arrayWork, int counter)
        {
            int sumTotal = 1;
            for (int i = 0; i < counter; i++)
            {
                sumTotal *= arrayWork[i];
            }
            return sumTotal;

        }//End Main()
    }//End class Program
}//End namespace Project9

