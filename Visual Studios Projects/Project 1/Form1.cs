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
// Project: Project 1
// Date: 1/16/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// --------------------------------------------------------------------------


namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mealBox_Leave(object sender, EventArgs e)
        {
            //constant doubles in order to find percentages of tips from my other double values
            const double TWENTYPERCENT = 0.2;
            const double FIFTEENPERCENT = 0.15;
            const double TENPERCENT = 0.1;

            //Making the mealValue a double insteadof a string and then miltiplying that value 3 seperate times for 3 different tip amounts
            double mealValue = double.Parse(mealBox.Text);
            double greatTip = mealValue * TWENTYPERCENT;
            double goodTip = mealValue * FIFTEENPERCENT;
            double poorTip = mealValue * TENPERCENT;

            //Formatting the double into a string and formatting the correct output as money
            string outGreat = $"{greatTip:C}";
            string outGood = $"{goodTip:C}";
            string outPoor = $"{poorTip:C}";

            //Making sure that the string goes to the correct display box
            greatBox.Text = outGreat;
            goodBox.Text = outGood;
            poorBox.Text = outPoor;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About section in GUI
            MessageBox.Show("Rider Jensen\nCS1400\nProject 1");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exiting the application
            this.Close();
        }

        private void mealBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
