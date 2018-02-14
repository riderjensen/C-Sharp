using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project11
{
    class Resistors
    {
        string inputLine;
        int index = 0;
        int resistorNumber = 1;
        double maxPowerRated;
        double specifiedResistence;

        double[] resistorPowerTested = new double[50];

        //Inputing the data into an array
        public void dataInput(StreamReader dataFile)
        {
            string inputField = dataFile.ReadLine();
            string[] splitInputField;
            splitInputField = inputField.Split();
            specifiedResistence = double.Parse(splitInputField[0]);
            maxPowerRated = double.Parse(splitInputField[1]);

            do
            {
                inputLine = dataFile.ReadLine();
                if (inputLine == null)
                    { break; }
                if (inputLine != null)
                    { resistorPowerTested[index] = double.Parse(inputLine); }
                index++;
            } while (inputLine != null);
        }

        public string dataOutput()
        {
            Console.WriteLine("Res#      Dissappation      Passed?");
            Console.WriteLine("");
            for (int i = 0; i < index; i++)
            {
                Console.Write(resistorNumber);
                resistorNumber++;
                Console.Write("            ");
                Console.Write(resistorPowerTested[i]);
                Console.Write("                ");
                if (resistorPowerTested[i] <= maxPowerRated)
                {
                    Console.WriteLine("Yes");
                }
                if (resistorPowerTested[i] > maxPowerRated)
                {
                    Console.WriteLine("No");
                }
            }
            return "End Program";
        }
    }
}
