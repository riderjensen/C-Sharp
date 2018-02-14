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
// Project: Project 2
// Date: 1/31/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// --------------------------------------------------------------------------


namespace Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ignore this 
        }

        private void userPressCalculate_Click(object sender, EventArgs e)
        {
            /*this method works when the calculate button is pressed. It will divide the gold, first for the captain
            and his mate and then divide it between the crew. Then it will give the remainder to the pirates benevolent fund. 
            */
            //constants
            const double JACKSHARE = 0.12;
            const double MATESHARE = 0.08;
            const int CAPTAINANDMATE = 2;
            const int PREGOLD = 3;

            //This is where the calculations should happen after the Calculate button is pressed
            double totalGoldAmount = double.Parse(userInputGold.Text);

            //this is taking out the 3 gold given to all crew members except the captain and first mate
            double preGoldTakenAmount = double.Parse(userInputPirates.Text) - CAPTAINANDMATE;
            double totalAmount = totalGoldAmount - (preGoldTakenAmount * PREGOLD);

            //Take the totalAmount of gold and give 12% to Jack
            double amountForJack = totalAmount * JACKSHARE;
            //cast - convert double to int
            int amountForJackRounded;
            amountForJackRounded = (int)amountForJack;
            //cast - convert double to int
            int totalAmountRounded;
            totalAmountRounded = (int)totalAmount;
            //total amount after Jack
            int amountMinusJack = totalAmountRounded - amountForJackRounded;
            outputJacksShare.Text = $"{amountForJackRounded:F0}";

            //take the amount after Jack and give 8% to first mate
            double amountForMate = amountMinusJack * MATESHARE;
            
            //cast - convert double to int
            int amountForMateRounded;
            amountForMateRounded = (int)amountForMate;
            outputMatesShare.Text = $"{amountForMateRounded:F0}";
            //now have the crew amount
            int amountForCrew = amountMinusJack - amountForMateRounded;

            //take the amountForCrew and divide it by the number of pirates 
            //(number of pirates should include Jack and First mate = amountForCrewDivided
            int amountForCrewDivided = amountForCrew / int.Parse(userInputPirates.Text);
            
           
            //display amount of gold for Crew members (amountForCrewDivided) = outputCrewMembersShare.Text
            outputCrewMembersShare.Text = $"{amountForCrewDivided:F0}";
           
            //use the remainder operator (%) to figure out what is left over from the amountForCrew / number of pirates = outputPiratesBenevolentFund.Text
            double outputPiratesBenevolentFundText = amountForCrew % int.Parse(userInputPirates.Text);
            outputPiratesBenevolentFund.Text = $"{outputPiratesBenevolentFundText:F0}";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this is to show a message box when the "about" button is clicked on the menu strip
            MessageBox.Show("Rider Jensen CS 1400 Project 2\nThe purpose of this project is \nto calculate the pirate treasure amounts");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this is to close the program when clicking exit from the menu bar
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //this method is to clear all the boxes and put in a zero there
            var emptyBox = 0;
            string outStr = $"{emptyBox:D}";
            userInputGold.Text = outStr;
            userInputPirates.Text = outStr;
            outputCrewMembersShare.Text = outStr;
            outputJacksShare.Text = outStr;
            outputMatesShare.Text = outStr;
            outputPiratesBenevolentFund.Text = outStr;
        }
    }
}
