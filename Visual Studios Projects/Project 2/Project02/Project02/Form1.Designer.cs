namespace Project02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userPressCalculate = new System.Windows.Forms.Button();
            this.userInputPirates = new System.Windows.Forms.TextBox();
            this.userInputGold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputJacksShare = new System.Windows.Forms.TextBox();
            this.outputMatesShare = new System.Windows.Forms.TextBox();
            this.outputCrewMembersShare = new System.Windows.Forms.TextBox();
            this.outputPiratesBenevolentFund = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPressCalculate
            // 
            this.userPressCalculate.Location = new System.Drawing.Point(102, 95);
            this.userPressCalculate.Name = "userPressCalculate";
            this.userPressCalculate.Size = new System.Drawing.Size(75, 23);
            this.userPressCalculate.TabIndex = 0;
            this.userPressCalculate.Text = "Calculate!";
            this.userPressCalculate.UseVisualStyleBackColor = true;
            this.userPressCalculate.Click += new System.EventHandler(this.userPressCalculate_Click);
            // 
            // userInputPirates
            // 
            this.userInputPirates.Location = new System.Drawing.Point(149, 31);
            this.userInputPirates.Name = "userInputPirates";
            this.userInputPirates.Size = new System.Drawing.Size(100, 20);
            this.userInputPirates.TabIndex = 1;
            // 
            // userInputGold
            // 
            this.userInputGold.Location = new System.Drawing.Point(149, 69);
            this.userInputGold.Name = "userInputGold";
            this.userInputGold.Size = new System.Drawing.Size(100, 20);
            this.userInputGold.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Pirates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Gold Coins";
            // 
            // outputJacksShare
            // 
            this.outputJacksShare.Location = new System.Drawing.Point(149, 137);
            this.outputJacksShare.Name = "outputJacksShare";
            this.outputJacksShare.Size = new System.Drawing.Size(100, 20);
            this.outputJacksShare.TabIndex = 5;
            // 
            // outputMatesShare
            // 
            this.outputMatesShare.Location = new System.Drawing.Point(149, 179);
            this.outputMatesShare.Name = "outputMatesShare";
            this.outputMatesShare.Size = new System.Drawing.Size(100, 20);
            this.outputMatesShare.TabIndex = 6;
            // 
            // outputCrewMembersShare
            // 
            this.outputCrewMembersShare.Location = new System.Drawing.Point(149, 222);
            this.outputCrewMembersShare.Name = "outputCrewMembersShare";
            this.outputCrewMembersShare.Size = new System.Drawing.Size(100, 20);
            this.outputCrewMembersShare.TabIndex = 7;
            // 
            // outputPiratesBenevolentFund
            // 
            this.outputPiratesBenevolentFund.Location = new System.Drawing.Point(149, 270);
            this.outputPiratesBenevolentFund.Name = "outputPiratesBenevolentFund";
            this.outputPiratesBenevolentFund.Size = new System.Drawing.Size(100, 20);
            this.outputPiratesBenevolentFund.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jack\'s Share";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Mate\'s Share";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Crew Member\'s Share";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pirate\'s Benevolent Fund";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(181, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear All Values";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputPiratesBenevolentFund);
            this.Controls.Add(this.outputCrewMembersShare);
            this.Controls.Add(this.outputMatesShare);
            this.Controls.Add(this.outputJacksShare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userInputGold);
            this.Controls.Add(this.userInputPirates);
            this.Controls.Add(this.userPressCalculate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Treasure Spliter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userPressCalculate;
        private System.Windows.Forms.TextBox userInputPirates;
        private System.Windows.Forms.TextBox userInputGold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputJacksShare;
        private System.Windows.Forms.TextBox outputMatesShare;
        private System.Windows.Forms.TextBox outputCrewMembersShare;
        private System.Windows.Forms.TextBox outputPiratesBenevolentFund;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
    }
}

