// File/Project Prolog
// Name: <PUT YOUR NAME HERE>
// CS 1400 Section 001
// Project: Project11
// Date: 4/18/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;
using System.IO;

namespace Project11
{
    static public class Program
    {
        static public void Main()
        {
            Resistors resistors = new Resistors();
                

            WriteLine("Resistor Batch Test Analysis Program");
            WriteLine("Data file must be in your documents folder");
            WriteLine("Please enter the name of your file. (I.E. resistors.txt)");
            string filePath = ReadLine();
            StreamReader dataFile = new StreamReader(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\" + filePath);

            resistors.dataInput(dataFile);
            resistors.dataOutput();


            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Project11

