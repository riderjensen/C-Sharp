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
// CS 1400 Section 1
// Project: Lab 6
// Date: 1/24/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// --------------------------------------------------------------------------

namespace Lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is the about box message
            MessageBox.Show("Rider Jensen CS 1400 Lab06\nThis program's purpose is to write in the diameter of a wagon wheel. The program then calculates how many turns of the wheel is equal to a mile");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //This is creating the method
            //Declare Variables Here
                //Variable One will be userWagonDiameterInput
                //Constant of inchInMile - amount of inches in a mile
                //Constant of pi
                //variable of circWheel - Circumfrence of wheel
                //variable of mileAmount
            //Equation will be Circumfrence = pi*d
            //Get user input of diameter of wheel from diameterAmountBox
            //Convert diameterAmountBox from string to double
            //Multiply diameterAmountBox*pi to get circWheel
            //Divide circWheel into Constant of inchInMile
                //make sure to round??
            //Put this into variable mileAmount
                //convert to string??
            //Display mileAmount in mileAmountBox
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //This is the close button for the program
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Dont type anything in here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This is the button that should clear input and output from both boxes
        }
    }
}
