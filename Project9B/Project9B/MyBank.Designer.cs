namespace Project9B
{
    partial class MyBank
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
            this.ATMmenuStrip = new System.Windows.Forms.MenuStrip();
            this.aTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mortgageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ATMmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ATMmenuStrip
            // 
            this.ATMmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTMToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.ATMmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ATMmenuStrip.Name = "ATMmenuStrip";
            this.ATMmenuStrip.Size = new System.Drawing.Size(487, 24);
            this.ATMmenuStrip.TabIndex = 0;
            this.ATMmenuStrip.Text = "menuStrip1";
            // 
            // aTMToolStripMenuItem
            // 
            this.aTMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTMToolStripMenuItem1});
            this.aTMToolStripMenuItem.Name = "aTMToolStripMenuItem";
            this.aTMToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aTMToolStripMenuItem.Text = "ATM";
            // 
            // aTMToolStripMenuItem1
            // 
            this.aTMToolStripMenuItem1.Name = "aTMToolStripMenuItem1";
            this.aTMToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aTMToolStripMenuItem1.Text = "ATM";
            this.aTMToolStripMenuItem1.Click += new System.EventHandler(this.aTMToolStripMenuItem1_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanApplicationToolStripMenuItem,
            this.mortgageCalculatorToolStripMenuItem});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // loanApplicationToolStripMenuItem
            // 
            this.loanApplicationToolStripMenuItem.Name = "loanApplicationToolStripMenuItem";
            this.loanApplicationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loanApplicationToolStripMenuItem.Text = "Loan Application";
            this.loanApplicationToolStripMenuItem.Click += new System.EventHandler(this.loanApplicationToolStripMenuItem_Click);
            // 
            // mortgageCalculatorToolStripMenuItem
            // 
            this.mortgageCalculatorToolStripMenuItem.Name = "mortgageCalculatorToolStripMenuItem";
            this.mortgageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mortgageCalculatorToolStripMenuItem.Text = "Mortgage Calculator";
            this.mortgageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.mortgageCalculatorToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem1});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // administratorToolStripMenuItem1
            // 
            this.administratorToolStripMenuItem1.Name = "administratorToolStripMenuItem1";
            this.administratorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.administratorToolStripMenuItem1.Text = "Administrator";
            this.administratorToolStripMenuItem1.Click += new System.EventHandler(this.administratorToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cwood19";
            // 
            // MyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ATMmenuStrip);
            this.Name = "MyBank";
            this.Text = "My Bank";
            this.ATMmenuStrip.ResumeLayout(false);
            this.ATMmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ATMmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mortgageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}

