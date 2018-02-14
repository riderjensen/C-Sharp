using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double angleC;
       

        public Triangle(double sA, double sB,double aC)
        {
            sideA = sA;
            sideB = sB;
            angleC = aC;           
        }
        

        //Calculate Side C
        //This method takes two sides and an angle and calculates the third side ofthe triangle
        //Inputs: two sides and an angle
        //Returns: Hypotenuse
        public double CalcSideC()
        {
            const double DEGREE_TO_RADIANS = Math.PI / 180;
            const double TWO = 2;
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB - TWO * sideA * sideB * Math.Cos(angleC * DEGREE_TO_RADIANS));
            return sideC;
        }
        //Calculates the area of the triangle
        //This method takes in two sides and finds the area
        //Inputs: two sides
        //Outputs: Area
        public double CalcArea()
        {
            const double HALF = 2;
            double areaTriangle = (sideA * sideB) / HALF;
            return areaTriangle;
        }

        
    }

}


