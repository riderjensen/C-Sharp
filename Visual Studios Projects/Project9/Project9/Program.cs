// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 01
// Project: Project9
// Date: 4/6/2017 
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Project9
{
    static public class Program
    {
        static public void Main()
        {
            //variables and const
            const int MAXNUMBER = 10;
            int numberOfTimes = 0;
            string userInput = "placeholder";
            //instantize class
            Bowlers bowlers = new Bowlers();
            bowlers.Team(MAXNUMBER);


            //asking for input
            WriteLine("Please enter the bowler's first name and score, seperated by a space.");
            while ((numberOfTimes <= MAXNUMBER) && (userInput != ""))
            {
                userInput = ReadLine();
                if (userInput == "")
                {
                    break;
                }
                bowlers.AddPlayer(userInput);
                numberOfTimes++;

                
            }
            WriteLine("Playes and Their Scores");
            //insert writing method from class
            WriteLine("{0}", bowlers.GetNamesAndScores());
            WriteLine("-------------------------------");
            WriteLine("The high score is {0}, by {1}", bowlers.highBowler(), bowlers.highBowlerName());
            WriteLine("The low score is {0}, by {1}", bowlers.lowBowler(), bowlers.lowBowlerName());
            WriteLine("The median score is {0}", bowlers.medianBowler());
            WriteLine("Press any key to continue ... ");
            ReadKey(true);
                   
        }//End Main()
    }//End class Program
}//End namespace Project9

