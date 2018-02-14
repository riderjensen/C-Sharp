using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// File/Project Prolog
// Name: Rider Jensen
// CS 1400 Section 001
// Project: Extra Credit Project
// Date: 4/25/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace ExtraProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //closing application
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message box
            MessageBox.Show("Rider Jensen. CS 1400 - 001. An extra project to show weight loss by multiple individuals over the course of a 5 week period.");
        }


        //Variables
        const int MAX = 20;
        string inputString;
        int counter = 0;
        string[] name = new string[MAX];
        double[] startingWeight = new double[MAX];
        double[] endingWeight = new double[MAX];
        double[] weightLost = new double[MAX];
        WeightLoss[] weightGone = new WeightLoss[MAX];
        int newCounter;

        //Adding the file
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            newCounter = 0;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);
                    do
                    {
                        //Inputing all the data into arrays
                        inputString = data.ReadLine();
                        if (inputString != null && counter < MAX)
                        {
                            name[counter] = inputString;
                            inputString = data.ReadLine();
                            string[] weightDivider = inputString.Split();
                            startingWeight[counter] = double.Parse(weightDivider[0]);
                            endingWeight[counter] = double.Parse(weightDivider[1]);
                            weightGone[counter] = new WeightLoss(startingWeight[counter], endingWeight[counter]);
                            weightLost[counter] = weightGone[counter].WeightGone();
                            counter++;
                        }
                    } while (inputString != null && counter < MAX);
                }
            }
        }
        //Next button Clicked
        private void button1_Click(object sender, EventArgs e)
        {
            if (name[newCounter] == null)
            {
                button1.Enabled = false;
            }
            textBox1.Text = name[newCounter];
            textBox2.Text = startingWeight[newCounter].ToString();
            textBox3.Text = endingWeight[newCounter].ToString();
            textBox4.Text = weightLost[newCounter].ToString("0.00");
            newCounter++;
        }
    }
    
}
