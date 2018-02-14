// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Lab25
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

namespace Lab25
{
    static public class Program
    {

        static public void Main()
        {
            string inputString;
            int i = 0;
            int[] scores = new int[50];
            StreamReader dataFile = new StreamReader(System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal) + "\\grades.txt");
            do
            {
                
                inputString = dataFile.ReadLine();
                if (inputString == null)
                    break;
                if (inputString != null)
                    WriteLine(inputString);
                scores[i] = int.Parse(inputString);
                i++;
            } while (inputString != null);

            double average = averageFromData(scores, i);
            WriteLine("The average is {0}", average);


            WriteLine("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()

        static double averageFromData(int[] scoresList, int index)
        {
            int totalSum = 0;
            for (int i = 0; i <= index; i++)
            {
                totalSum = scoresList[i] + totalSum;
            }
            double medianScore = totalSum / index;
            return medianScore;
        }

    }//End class Program
}//End namespace Lab25

