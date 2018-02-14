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
// Project: Project 6
// Date: 3/9/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Project_6
{
    public partial class Form1 : Form
    {   
        //put in bool variable for button press in global so I can call it later in seperate part
        bool surchargeButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Message box
            MessageBox.Show("CS 1400 Project 5. Used to calculate shipping costs");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exit
            this.Close();
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Per lbs or per items box text change
            string selectedItem = CategoryBox.Text;
            if(selectedItem == "Per Lb")
            {
                label4.Text = "In Lbs:";
            }
            if(selectedItem == "Per Item")
            {
                label4.Text = "Number of Items";
            }
            
        }

        private void shippingMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shipping method index change
        }
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            //Radio button yes
            if (radioButtonYes.Checked)
            {
                surchargeButton = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //variables
            string shippingMethod;
            string category;
            double numberOfItemsLbs;

            //assigning variables
            shippingMethod = shippingMethodBox.Text;
            category = CategoryBox.Text;
            numberOfItemsLbs = double.Parse(numberOfItemsBox.Text);
            //calling class and method for surcharge method
            if (surchargeButton == true)
            {
                RedFernLogic myRedFernLogic = new RedFernLogic(shippingMethod, category, numberOfItemsLbs, surchargeButton);
                string totalAmount = String.Format("{0:C}", myRedFernLogic.setShippingSurcharge());
                totalCostBox.Text = totalAmount;
            }
            //calling class for non-surcharge method
            if (surchargeButton == false)
            {
                RedFernLogic myRedFernLogic = new RedFernLogic(shippingMethod, category, numberOfItemsLbs);
                string totalAmount = String.Format("{0:C}", myRedFernLogic.setShipping());
                totalCostBox.Text = totalAmount;
            }
            
        }
        
        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            //radio button no
            if (radioButtonNo.Checked)
            {
                surchargeButton = false;
            }

        }
    }
}
