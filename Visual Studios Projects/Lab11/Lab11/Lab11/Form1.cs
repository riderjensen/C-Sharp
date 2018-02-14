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
// Project: Lab11
// Date: 2/14/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //dont type here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dont type here
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lab 11 by Rider Jensen. Calculating sides of triangles.");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double side1;
            double side2;
            //get user input
            side1 = double.Parse(sideAInput.Text);
            side2 = double.Parse(sideBInput.Text);
            //call method back
            double hypo = CalcHypotenuse(side1, side2);
            //display
            string side3 = String.Format("{0:F2}", hypo);
            sideCOutput.Text = side3;

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
