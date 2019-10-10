namespace Project9B
{
    partial class MortgageCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthPayLabel = new System.Windows.Forms.Label();
            this.yearsBox = new System.Windows.Forms.TextBox();
            this.interestRateBox = new System.Windows.Forms.TextBox();
            this.loanAmtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.avgMonthPayLabel = new System.Windows.Forms.Label();
            this.totalMonthPayLabel = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.awesomeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "cwood19";
            // 
            // monthPayLabel
            // 
            this.monthPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthPayLabel.Location = new System.Drawing.Point(442, 169);
            this.monthPayLabel.Name = "monthPayLabel";
            this.monthPayLabel.Size = new System.Drawing.Size(200, 50);
            this.monthPayLabel.TabIndex = 8;
            // 
            // yearsBox
            // 
            this.yearsBox.Location = new System.Drawing.Point(442, 117);
            this.yearsBox.Name = "yearsBox";
            this.yearsBox.Size = new System.Drawing.Size(200, 20);
            this.yearsBox.TabIndex = 20;
            // 
            // interestRateBox
            // 
            this.interestRateBox.Location = new System.Drawing.Point(442, 64);
            this.interestRateBox.Name = "interestRateBox";
            this.interestRateBox.Size = new System.Drawing.Size(200, 20);
            this.interestRateBox.TabIndex = 19;
            // 
            // loanAmtBox
            // 
            this.loanAmtBox.Location = new System.Drawing.Point(442, 23);
            this.loanAmtBox.Name = "loanAmtBox";
            this.loanAmtBox.Size = new System.Drawing.Size(200, 20);
            this.loanAmtBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.avgMonthPayLabel);
            this.groupBox1.Controls.Add(this.totalMonthPayLabel);
            this.groupBox1.Controls.Add(this.totalLoanLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(254, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // avgMonthPayLabel
            // 
            this.avgMonthPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgMonthPayLabel.Location = new System.Drawing.Point(188, 202);
            this.avgMonthPayLabel.Name = "avgMonthPayLabel";
            this.avgMonthPayLabel.Size = new System.Drawing.Size(200, 50);
            this.avgMonthPayLabel.TabIndex = 0;
            // 
            // totalMonthPayLabel
            // 
            this.totalMonthPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalMonthPayLabel.Location = new System.Drawing.Point(188, 130);
            this.totalMonthPayLabel.Name = "totalMonthPayLabel";
            this.totalMonthPayLabel.Size = new System.Drawing.Size(200, 50);
            this.totalMonthPayLabel.TabIndex = 0;
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLoanLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLoanLabel.Location = new System.Drawing.Point(188, 46);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(200, 50);
            this.totalLoanLabel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Average Monthly Payments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Monthly Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total of All Loans";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monthly Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Years";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Annual Interest Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Amount of Loan";
            // 
            // awesomeButton
            // 
            this.awesomeButton.AutoSize = true;
            this.awesomeButton.Location = new System.Drawing.Point(523, 616);
            this.awesomeButton.Name = "awesomeButton";
            this.awesomeButton.Size = new System.Drawing.Size(97, 23);
            this.awesomeButton.TabIndex = 17;
            this.awesomeButton.Text = "&Awesome Button";
            this.awesomeButton.UseVisualStyleBackColor = true;
            this.awesomeButton.Click += new System.EventHandler(this.awesomeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(442, 616);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(361, 616);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(280, 616);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 663);
            this.Controls.Add(this.monthPayLabel);
            this.Controls.Add(this.yearsBox);
            this.Controls.Add(this.interestRateBox);
            this.Controls.Add(this.loanAmtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.awesomeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label1);
            this.Name = "MortgageCalculator";
            this.Text = "Mortgage Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monthPayLabel;
        private System.Windows.Forms.TextBox yearsBox;
        private System.Windows.Forms.TextBox interestRateBox;
        private System.Windows.Forms.TextBox loanAmtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label avgMonthPayLabel;
        private System.Windows.Forms.Label totalMonthPayLabel;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button awesomeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calcButton;
    }
}