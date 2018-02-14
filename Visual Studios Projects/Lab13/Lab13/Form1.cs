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
// Project: Lab13
// Date: 2/23/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Lab13
{
    public partial class Form1 : Form
    {
        //Declare 
        MyTokenMachine myMachine = new MyTokenMachine();

        public Form1()
        {
            InitializeComponent();
            
            string txtForTokens = String.Format("{0:D}", myMachine.CountTokens());
            string txtForQuarters = String.Format("{0:D}", myMachine.CountQuarters());
            tokenTextBox.Text = txtForTokens;
            quarterTextBox.Text = txtForQuarters;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //dont touch
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rider Jensen Token Machine. Lab 13.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get token button
            myMachine.GetTokens();
            string txtForTokens = String.Format("{0:D}", myMachine.CountTokens());
            string txtForQuarters = String.Format("{0:D}", myMachine.CountQuarters());
            tokenTextBox.Text = txtForTokens;
            quarterTextBox.Text = txtForQuarters;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset button
            myMachine.ResetMethod();
            string txtForTokens = String.Format("{0:D}", myMachine.CountTokens());
            string txtForQuarters = String.Format("{0:D}", myMachine.CountQuarters());
            tokenTextBox.Text = txtForTokens;
            quarterTextBox.Text = txtForQuarters;
        }
    }
}
