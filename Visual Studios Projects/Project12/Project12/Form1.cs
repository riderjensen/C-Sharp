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
// Project: Project12
// Date: 4/25/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Project12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dont type here
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rider Jensen Project 12. PayRoll Fluffle Shuffle");
        }


        //Variables
        const int MAX = 10;
        string inputString;
        int counter = 0;
        int[] employeeNumber = new int[MAX];
        string[] employeeName = new string[MAX];
        string[] employeeAddress = new string[MAX];
        double[] employeeNetPay = new double[MAX];
        EmployeeMoney[] monies = new EmployeeMoney[MAX];
        int newCounter;


        //open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                        inputString = data.ReadLine();
                        if (inputString != null && counter < MAX)
                        {
                            
                        employeeNumber[counter] = int.Parse(inputString);
                        inputString = data.ReadLine();
                        employeeName[counter] = inputString;
                        inputString = data.ReadLine();
                        employeeAddress[counter] = inputString;
                        inputString = data.ReadLine();
                        string[] employeeMoney = inputString.Split();
                        double employeePay = double.Parse(employeeMoney[0]);
                        int employeeHours = int.Parse(employeeMoney[1]);
                        monies[counter] = new EmployeeMoney(employeePay, employeeHours);
                        employeeNetPay[counter] = monies[counter].CalcSalary();
                        counter++;
                        }
                    } while (inputString != null && counter < MAX);
                }
            }
        }
        //button click for next
        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeName[newCounter] == null)
            {
               button1.Enabled = false;
            }
            textBox1.Text = employeeName[newCounter];
            textBox2.Text = employeeAddress[newCounter];
            textBox3.Text = (employeeNetPay[newCounter]).ToString("$000.00");
            newCounter++;
        }
    }
}
