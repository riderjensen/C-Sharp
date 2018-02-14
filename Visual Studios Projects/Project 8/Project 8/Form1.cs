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
// Project: Project 8
// Date: 3/28/17
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Project_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rider Jensen CS 1400-001 \nProject 8");
            //message box on menu
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            //exit button on menu
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int diceOne = 0;
            int diceTwo = 0;
            int dTotal;

            string one = "n";
            string two = "n" + "n";
            string three = "n" + "n" + "n";
            string four = "n" + "n" + "n" + "n";
            string five = "n" + "n" + "n" + "n" + "n";
            string six = "n" + "n" + "n" + "n" + "n" + "n";


            //Press the roll dice button and display the dice
            RollDice myRollDice = new RollDice();
            myRollDice.RollingDiceOne(ref diceOne);
            myRollDice.RollingDiceOne(ref diceTwo);
            dTotal = diceOne + diceTwo;

            if (dTotal == 2) { messageDiceBox.Text = "You rolled Snake Eyes!"; }
            if (dTotal == 12) { messageDiceBox.Text = "You rolled Box Cars!"; }
            if (dTotal != 2 && dTotal != 12) { messageDiceBox.Text = string.Format("You rolled {0}", dTotal); }

            //display the dice boxes

            if (diceOne == 1) { diceBoxOne.Text = one; }
            if (diceOne == 2) { diceBoxOne.Text = two; }
            if (diceOne == 3) { diceBoxOne.Text = three; }
            if (diceOne == 4) { diceBoxOne.Text = four; }
            if (diceOne == 5) { diceBoxOne.Text = five; }
            if (diceOne == 6) { diceBoxOne.Text = six; }
            if (diceTwo == 1) { diceBoxTwo.Text = one; }
            if (diceTwo == 2) { diceBoxTwo.Text = two; }
            if (diceTwo == 3) { diceBoxTwo.Text = three; }
            if (diceTwo == 4) { diceBoxTwo.Text = four; }
            if (diceTwo == 5) { diceBoxTwo.Text = five; }
            if (diceTwo == 6) { diceBoxTwo.Text = six; }



        }
    }
}
