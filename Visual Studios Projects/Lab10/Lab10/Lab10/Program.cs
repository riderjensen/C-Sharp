using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab10
// Date: 2/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for first side of right triangle
            //second side of triangle
            Console.WriteLine("Please enter in the value for side 1.");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the value for side 2.");
            double side2 = double.Parse(Console.ReadLine());
            //call
            double hypo = CalcHypotenuse(side1, side2);
            Console.WriteLine($"The hypotenuse is {hypo:0.00}");
            //display
            Console.ReadLine();
        }

        //Name: Calc Hypotenuse
        //Purpose: Take in the sides of a right triangle and return the hypotenuse
        //Input: The lengths of the two sides
        //Output: the length of the hypotenuse
        static double CalcHypotenuse(double side1, double side2)
        {
            const int SQUARE_FACTOR = 2;
            //square side1
            side1 = Math.Pow(side1, SQUARE_FACTOR);
            //square side2
            side2 = Math.Pow(side2, SQUARE_FACTOR);


            double hypo = Math.Sqrt(side1 + side2);
            return hypo;
        }
            
            
    }
}
