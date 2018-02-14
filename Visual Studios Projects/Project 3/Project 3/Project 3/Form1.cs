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
// Project: Project 3
// Date: 2/7/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get input from user for old start time
            int oldStartTime = int.Parse(oldStartTime.Text);
            //Get input from user for old end time
            int oldEndTime = int.Parse(oldEndTime.Text);
            //Convert these into minutes
            //Take the difference between them(old end time – old start time)
            //Multiply this by 1.25
            //Add that amount to the old start time in order to find the new end time
            //Display

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rider Jensen/nProject 03/nThis program shows the new delivery time of the packages during constructions on I-15");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
