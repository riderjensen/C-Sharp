// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab27
// Date: 4/25/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;
using System.IO;

namespace Lab27
{
    static public class Program
    {
        static public void Main()
        {
            const int MAX = 10;
            string inputString;
            int counter = 0;
            Box[] boxes = new Box[MAX];

            StreamReader dataFile = new StreamReader(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\boxes.txt");

            do
            {
                inputString = dataFile.ReadLine();
                if (inputString != null && counter < MAX)
                {
                    string[] data = inputString.Split();
                    int dataH = int.Parse(data[0]);
                    int dataW = int.Parse(data[1]);
                    int dataL = int.Parse(data[2]);
                    boxes[counter++] = new Lab27.Box(dataH, dataW, dataL);

                }
            } while (inputString != null && counter < MAX);


            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("The volume of the box{0:d} is {1:d} cubic inches", i+1, boxes[i].GetVolume());
            }


                Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Lab27

