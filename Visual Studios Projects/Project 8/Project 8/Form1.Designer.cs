namespace Project_8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rollButton = new System.Windows.Forms.Button();
            this.diceBoxOne = new System.Windows.Forms.TextBox();
            this.diceBoxTwo = new System.Windows.Forms.TextBox();
            this.messageDiceBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(104, 194);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(119, 60);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll The Dice!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diceBoxOne
            // 
            this.diceBoxOne.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.diceBoxOne.Location = new System.Drawing.Point(51, 54);
            this.diceBoxOne.Multiline = true;
            this.diceBoxOne.Name = "diceBoxOne";
            this.diceBoxOne.Size = new System.Drawing.Size(105, 108);
            this.diceBoxOne.TabIndex = 2;
            // 
            // diceBoxTwo
            // 
            this.diceBoxTwo.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.diceBoxTwo.Location = new System.Drawing.Point(187, 54);
            this.diceBoxTwo.Multiline = true;
            this.diceBoxTwo.Name = "diceBoxTwo";
            this.diceBoxTwo.Size = new System.Drawing.Size(104, 108);
            this.diceBoxTwo.TabIndex = 3;
            // 
            // messageDiceBox
            // 
            this.messageDiceBox.Location = new System.Drawing.Point(60, 168);
            this.messageDiceBox.Name = "messageDiceBox";
            this.messageDiceBox.Size = new System.Drawing.Size(215, 20);
            this.messageDiceBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 289);
            this.Controls.Add(this.messageDiceBox);
            this.Controls.Add(this.diceBoxTwo);
            this.Controls.Add(this.diceBoxOne);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rolling Dice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox diceBoxOne;
        private System.Windows.Forms.TextBox diceBoxTwo;
        private System.Windows.Forms.TextBox messageDiceBox;
    }
}

