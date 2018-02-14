using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Project4
// Date: 2/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project4
{
    public partial class Form1 : Form
    {
        //Global Variables
        const int SQUARE_FACTOR = 2;
        const int HALF_DEGREES_IN_CIRCLE = 180;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rider Jensen Project 4. Finding the side of a triangle based on an angle and two sides.");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variables
            double side1;
            double side2;
            double angleC;
            //get user input
            side1 = double.Parse(sideAInput.Text);
            side2 = double.Parse(sideBInput.Text);
            angleC = double.Parse(AngleCInput.Text);
            //call method back
            double hypo = CalcHypotenuse(side1, side2, angleC);
            double angleA = CalcAngleA(side1, side2, hypo);
            double angleB = CalcAngleB(angleC, angleA);
            //display
            string side3 = String.Format("{0:F2}", hypo);
            sideCOuptut.Text = side3;
            string angleAFormat = String.Format("{0:F2}", angleA);
            angleAOutput.Text = angleAFormat;
            string angleBFormat = String.Format("{0:F2}", angleB);
            angleBOutput.Text = angleBFormat;

        }

        //Name: CalcHypotenuse
        //Purpose: Calculate the hypotenuse of a triangle given two sides and an angle
        //Input: Lengths of a, b and the angle of C
        //Output: The length of the hypotenuse
        static double CalcHypotenuse(double side1, double side2, double angleC)
        {
            double side1Squared;
            double side2Squared;
            double angleCInRad;
            //square side one
            side1Squared = Math.Pow(side1, SQUARE_FACTOR);
            //square side two
            side2Squared = Math.Pow(side2, SQUARE_FACTOR);
            //convert angleC to radians
            angleCInRad = angleC * Math.PI / HALF_DEGREES_IN_CIRCLE;
            //plug values into equation
            //FIX THIS
            double hypoSquared = side1Squared + side2Squared - (2 * side1 * side2 * Math.Cos(angleCInRad));
            double hypo = Math.Sqrt(hypoSquared);
            //return hypo
            return hypo;

        }
        //Name: CalcAngleA
        //Purpose: Calculate Angle A
        //Input: Side 1, 2 and 3
        //Output: Angle A
        static double CalcAngleA(double side1, double side2, double hypo)
        {
            double angleAInRad = Math.Acos(((Math.Pow(side2, SQUARE_FACTOR) + Math.Pow(hypo, SQUARE_FACTOR) - Math.Pow(side1, SQUARE_FACTOR)) / (2 * side2 * hypo)));
            double angleA = angleAInRad * (HALF_DEGREES_IN_CIRCLE / Math.PI);
            return angleA;
        }

        //Name: CalcAngleC
        //Purpose: Calculate the angle of C
        //Input: the other 2 angles
        //Output: The last angle
        static double CalcAngleB(double angleA, double angleC)
        {
            double angleB = HALF_DEGREES_IN_CIRCLE - (angleA + angleC);
            return angleB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clears the text boxes
            int clear = 0;
            string cleared = String.Format("{0}", clear);
            sideAInput.Text = cleared;
            sideBInput.Text = cleared;
            AngleCInput.Text = cleared;
            sideCOuptut.Text = cleared;
            angleAOutput.Text = cleared;
            angleBOutput.Text = cleared;
        }
    }
}
