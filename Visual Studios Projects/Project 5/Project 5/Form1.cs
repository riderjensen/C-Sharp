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
// Project: Project 5
// Date: 3/2/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About Box
            MessageBox.Show("Rider Jensen. Project 5 to calculate prices of items");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //Calculate the prices
            double numberOfItems;
            double unitPrice;
            //Input Text from user
            numberOfItems = double.Parse(numberOfItemsBox.Text);
            unitPrice = double.Parse(unitPriceBox.Text);
            //Send data to class
            SalesInvoice mySalesInvoice = new SalesInvoice(numberOfItems, unitPrice);
            //Show message box
            MessageBox.Show(mySalesInvoice.PrintInvoice());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the boxes
            
            numberOfItemsBox.Clear();
            unitPriceBox.Clear();

        }
    }
}
