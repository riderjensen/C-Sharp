using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraProject
{
    class WeightLoss
    {
        //variables
        double startingWeight;
        double endingWeight;
        const int FIVEWEEKS = 5;

        //setters
        public WeightLoss(double sW, double eW)
        {
            startingWeight = sW;
            endingWeight = eW;    
        }

        //Weight Gone
        //Calculates weight loss over a 5 week period
        //Inputs: Starting weight, ending weight, and const 5 weeks
        //outputs: weight loss over 5 weeks
        public double WeightGone()
        {
            double returnNumber;
            returnNumber = ((startingWeight - endingWeight) / FIVEWEEKS);
            return returnNumber;
        }
    }
}
