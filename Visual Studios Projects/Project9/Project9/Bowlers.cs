using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project9
{
    class Bowlers
    {
        //variables
        private string[] names;
        private int[] scores;
        private int index;
        const int MAXTEAM = 10;
        private int highBowlerPosition;
        private int lowBowlerPosition;


        //setters
        public void Team(int size)
        {
            names = new string[size];
            scores = new int[size];
            index = 0;
        }

        //AddPlayer
        //Adds the player name and score to different arrays
        //Input: User input string
        //Output: None
        public void AddPlayer(string input)
        {
            if(index <= MAXTEAM)
            {
                string[] splitInput; 
                splitInput = input.Split();
                string nameing = splitInput[0];
                int scoreing = int.Parse(splitInput[1]);
                names[index] = nameing;
                scores[index] = scoreing;

                //issue is this index is creating an extra, unfilled low point. Need to remove it somehow but keep the index++
                index++;
            }
            
        }

        //GetNamesAndScores
        //Gets the names and scores of all people inputed and displays them
        //Input: None
        //Output: All of the players and their scores
        public string GetNamesAndScores()
        {
            for(int i = 0; i < index; i++)
            {
                Console.Write(names[i]);
                Console.Write(" - ");
                Console.Write(scores[i]);
                Console.WriteLine("");
            }
            return "";
        }

        //HighBowler
        //Finds the high score
        //Input: Score Array
        //Output: High score for bowler
        public int highBowler()
        {
            //search the array for highest value and return
            int highBowler = scores.Max();
            highBowlerPosition = Array.IndexOf(scores, highBowler);
            return highBowler;
        }

        //HighBowlerName
        //Finds the high bowler's name
        //Input: bowler Position in the array
        //Output: Bowler name as a string
        public string highBowlerName()
        {
            string bowlerName = names[highBowlerPosition];
            return bowlerName;
        }
        
        //LowBowler
        //Finds the lowest score
        //Input: score array
        //Output: Low score
        public int lowBowler()
        {
            //search the array for the lowest value and return
            //this is more than the largest number that should be entered into the program
            int compareVari = 301;
            for (int i = 0; i < index; i++)
            {
                int placeholderNumber = scores[i];
                if(placeholderNumber < compareVari)
                {
                    compareVari = placeholderNumber;
                }
            }
                lowBowlerPosition = Array.IndexOf(scores, compareVari);    
            return compareVari;
        }

        //LowBowlerName
        //Finds the low bowler's name
        //Input: bowler Position in the array
        //Output: Bowler name as a string
        public string lowBowlerName()
        {
                string bowlerName = names[lowBowlerPosition];
                return bowlerName;
        }

        //MedianBowler
        //Finds the median score of the bowlers
        //Input: score array
        //Output : median scores
        public int medianBowler()
        {
            int sumOfScores = scores.Sum();
            int realMedian = sumOfScores / index;
            return realMedian;

            //int medianScore = 0;
            //int realMedian;
            //for(int i = 0; i < index; i++)
            //{
            //    medianScore += scores[i];
            //}
            //realMedian = medianScore / index;
            //return realMedian;
        }
    }
  
}
