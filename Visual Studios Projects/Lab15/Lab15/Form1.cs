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
// Project: Lab15
// Date: 3/2/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab15
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dont touch
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Calculate Button
            double sideA;
            double sideB;
            double angleC = 90;
            sideA = double.Parse(sideAInput.Text);
            sideB = double.Parse(sideBInput.Text);
            //Parameterized Constructor
            Triangle myTriangle = new Triangle(sideA, sideB, angleC);
            //Display
            string hypotenuse = String.Format("{0:F2}", myTriangle.CalcSideC());
            hypoOutput.Text = hypotenuse;
            string area = String.Format("{0:F2}", myTriangle.CalcArea());
            areaBox.Text = area;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lab 15 By Rider Jensen. Used to calculate the hypotenuse and area of a right triangle");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
