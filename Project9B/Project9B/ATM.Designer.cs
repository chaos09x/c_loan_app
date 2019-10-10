namespace Project9B
{
    partial class ATM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.amountTextBoxC = new System.Windows.Forms.TextBox();
            this.balanceLabelC = new System.Windows.Forms.Label();
            this.balanceLabel2 = new System.Windows.Forms.Label();
            this.amountLabelC = new System.Windows.Forms.Label();
            this.transactionGroupBoxC = new System.Windows.Forms.GroupBox();
            this.withdrawRadioButtonC = new System.Windows.Forms.RadioButton();
            this.depositRadioButtonC = new System.Windows.Forms.RadioButton();
            this.exitButtonC = new System.Windows.Forms.Button();
            this.myButtonC = new System.Windows.Forms.Button();
            this.clearButtonC = new System.Windows.Forms.Button();
            this.submitButtonC = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.amountTextBoxS = new System.Windows.Forms.TextBox();
            this.balanceLabelS = new System.Windows.Forms.Label();
            this.balanceLabel4 = new System.Windows.Forms.Label();
            this.amountLabelS = new System.Windows.Forms.Label();
            this.transactionGroupBoxS = new System.Windows.Forms.GroupBox();
            this.withdrawRadioButtonS = new System.Windows.Forms.RadioButton();
            this.depositRadioButtonS = new System.Windows.Forms.RadioButton();
            this.exitButtonS = new System.Windows.Forms.Button();
            this.myButtonS = new System.Windows.Forms.Button();
            this.clearButtonS = new System.Windows.Forms.Button();
            this.submitButtonS = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.transactionGroupBoxC.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.transactionGroupBoxS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "cwood19";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 295);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amountTextBoxC);
            this.tabPage1.Controls.Add(this.balanceLabelC);
            this.tabPage1.Controls.Add(this.balanceLabel2);
            this.tabPage1.Controls.Add(this.amountLabelC);
            this.tabPage1.Controls.Add(this.transactionGroupBoxC);
            this.tabPage1.Controls.Add(this.exitButtonC);
            this.tabPage1.Controls.Add(this.myButtonC);
            this.tabPage1.Controls.Add(this.clearButtonC);
            this.tabPage1.Controls.Add(this.submitButtonC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Checking";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // amountTextBoxC
            // 
            this.amountTextBoxC.Location = new System.Drawing.Point(87, 30);
            this.amountTextBoxC.Name = "amountTextBoxC";
            this.amountTextBoxC.Size = new System.Drawing.Size(100, 20);
            this.amountTextBoxC.TabIndex = 1;
            // 
            // balanceLabelC
            // 
            this.balanceLabelC.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabelC.Location = new System.Drawing.Point(296, 30);
            this.balanceLabelC.Name = "balanceLabelC";
            this.balanceLabelC.Size = new System.Drawing.Size(100, 23);
            this.balanceLabelC.TabIndex = 7;
            // 
            // balanceLabel2
            // 
            this.balanceLabel2.AutoSize = true;
            this.balanceLabel2.Location = new System.Drawing.Point(226, 31);
            this.balanceLabel2.Name = "balanceLabel2";
            this.balanceLabel2.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel2.TabIndex = 6;
            this.balanceLabel2.Text = "Balance";
            // 
            // amountLabelC
            // 
            this.amountLabelC.AutoSize = true;
            this.amountLabelC.Location = new System.Drawing.Point(14, 31);
            this.amountLabelC.Name = "amountLabelC";
            this.amountLabelC.Size = new System.Drawing.Size(43, 13);
            this.amountLabelC.TabIndex = 5;
            this.amountLabelC.Text = "Amount";
            // 
            // transactionGroupBoxC
            // 
            this.transactionGroupBoxC.Controls.Add(this.withdrawRadioButtonC);
            this.transactionGroupBoxC.Controls.Add(this.depositRadioButtonC);
            this.transactionGroupBoxC.Location = new System.Drawing.Point(17, 65);
            this.transactionGroupBoxC.Name = "transactionGroupBoxC";
            this.transactionGroupBoxC.Size = new System.Drawing.Size(200, 100);
            this.transactionGroupBoxC.TabIndex = 4;
            this.transactionGroupBoxC.TabStop = false;
            this.transactionGroupBoxC.Text = "Transaction Type";
            // 
            // withdrawRadioButtonC
            // 
            this.withdrawRadioButtonC.AutoSize = true;
            this.withdrawRadioButtonC.Location = new System.Drawing.Point(7, 44);
            this.withdrawRadioButtonC.Name = "withdrawRadioButtonC";
            this.withdrawRadioButtonC.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioButtonC.TabIndex = 1;
            this.withdrawRadioButtonC.TabStop = true;
            this.withdrawRadioButtonC.Text = "Withdraw";
            this.withdrawRadioButtonC.UseVisualStyleBackColor = true;
            this.withdrawRadioButtonC.CheckedChanged += new System.EventHandler(this.withdrawRadioButtonC_CheckedChanged);
            // 
            // depositRadioButtonC
            // 
            this.depositRadioButtonC.AutoSize = true;
            this.depositRadioButtonC.Location = new System.Drawing.Point(7, 20);
            this.depositRadioButtonC.Name = "depositRadioButtonC";
            this.depositRadioButtonC.Size = new System.Drawing.Size(61, 17);
            this.depositRadioButtonC.TabIndex = 0;
            this.depositRadioButtonC.TabStop = true;
            this.depositRadioButtonC.Text = "Deposit";
            this.depositRadioButtonC.UseVisualStyleBackColor = true;
            this.depositRadioButtonC.CheckedChanged += new System.EventHandler(this.depositRadioButtonC_CheckedChanged);
            // 
            // exitButtonC
            // 
            this.exitButtonC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButtonC.Location = new System.Drawing.Point(605, 189);
            this.exitButtonC.Name = "exitButtonC";
            this.exitButtonC.Size = new System.Drawing.Size(75, 23);
            this.exitButtonC.TabIndex = 3;
            this.exitButtonC.Text = "&Exit";
            this.exitButtonC.UseVisualStyleBackColor = true;
            this.exitButtonC.Click += new System.EventHandler(this.exitButtonC_Click);
            // 
            // myButtonC
            // 
            this.myButtonC.AutoSize = true;
            this.myButtonC.Location = new System.Drawing.Point(400, 189);
            this.myButtonC.Name = "myButtonC";
            this.myButtonC.Size = new System.Drawing.Size(97, 23);
            this.myButtonC.TabIndex = 2;
            this.myButtonC.Text = "&Awesome Button";
            this.myButtonC.UseVisualStyleBackColor = true;
            this.myButtonC.Click += new System.EventHandler(this.myButtonC_Click);
            // 
            // clearButtonC
            // 
            this.clearButtonC.Location = new System.Drawing.Point(218, 189);
            this.clearButtonC.Name = "clearButtonC";
            this.clearButtonC.Size = new System.Drawing.Size(75, 23);
            this.clearButtonC.TabIndex = 1;
            this.clearButtonC.Text = "&Clear";
            this.clearButtonC.UseVisualStyleBackColor = true;
            this.clearButtonC.Click += new System.EventHandler(this.clearButtonC_Click);
            // 
            // submitButtonC
            // 
            this.submitButtonC.Location = new System.Drawing.Point(10, 189);
            this.submitButtonC.Name = "submitButtonC";
            this.submitButtonC.Size = new System.Drawing.Size(75, 23);
            this.submitButtonC.TabIndex = 0;
            this.submitButtonC.Text = "&Submit";
            this.submitButtonC.UseVisualStyleBackColor = true;
            this.submitButtonC.Click += new System.EventHandler(this.submitButtonC_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.amountTextBoxS);
            this.tabPage2.Controls.Add(this.balanceLabelS);
            this.tabPage2.Controls.Add(this.balanceLabel4);
            this.tabPage2.Controls.Add(this.amountLabelS);
            this.tabPage2.Controls.Add(this.transactionGroupBoxS);
            this.tabPage2.Controls.Add(this.exitButtonS);
            this.tabPage2.Controls.Add(this.myButtonS);
            this.tabPage2.Controls.Add(this.clearButtonS);
            this.tabPage2.Controls.Add(this.submitButtonS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Savings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // amountTextBoxS
            // 
            this.amountTextBoxS.Location = new System.Drawing.Point(85, 19);
            this.amountTextBoxS.Name = "amountTextBoxS";
            this.amountTextBoxS.Size = new System.Drawing.Size(100, 20);
            this.amountTextBoxS.TabIndex = 2;
            // 
            // balanceLabelS
            // 
            this.balanceLabelS.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabelS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabelS.Location = new System.Drawing.Point(296, 18);
            this.balanceLabelS.Name = "balanceLabelS";
            this.balanceLabelS.Size = new System.Drawing.Size(100, 23);
            this.balanceLabelS.TabIndex = 16;
            // 
            // balanceLabel4
            // 
            this.balanceLabel4.AutoSize = true;
            this.balanceLabel4.Location = new System.Drawing.Point(226, 19);
            this.balanceLabel4.Name = "balanceLabel4";
            this.balanceLabel4.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel4.TabIndex = 15;
            this.balanceLabel4.Text = "Balance";
            // 
            // amountLabelS
            // 
            this.amountLabelS.AutoSize = true;
            this.amountLabelS.Location = new System.Drawing.Point(14, 19);
            this.amountLabelS.Name = "amountLabelS";
            this.amountLabelS.Size = new System.Drawing.Size(43, 13);
            this.amountLabelS.TabIndex = 14;
            this.amountLabelS.Text = "Amount";
            // 
            // transactionGroupBoxS
            // 
            this.transactionGroupBoxS.Controls.Add(this.withdrawRadioButtonS);
            this.transactionGroupBoxS.Controls.Add(this.depositRadioButtonS);
            this.transactionGroupBoxS.Location = new System.Drawing.Point(17, 63);
            this.transactionGroupBoxS.Name = "transactionGroupBoxS";
            this.transactionGroupBoxS.Size = new System.Drawing.Size(200, 100);
            this.transactionGroupBoxS.TabIndex = 13;
            this.transactionGroupBoxS.TabStop = false;
            this.transactionGroupBoxS.Text = "Transaction Type";
            // 
            // withdrawRadioButtonS
            // 
            this.withdrawRadioButtonS.AutoSize = true;
            this.withdrawRadioButtonS.Location = new System.Drawing.Point(7, 44);
            this.withdrawRadioButtonS.Name = "withdrawRadioButtonS";
            this.withdrawRadioButtonS.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioButtonS.TabIndex = 1;
            this.withdrawRadioButtonS.TabStop = true;
            this.withdrawRadioButtonS.Text = "Withdraw";
            this.withdrawRadioButtonS.UseVisualStyleBackColor = true;
            // 
            // depositRadioButtonS
            // 
            this.depositRadioButtonS.AutoSize = true;
            this.depositRadioButtonS.Location = new System.Drawing.Point(7, 20);
            this.depositRadioButtonS.Name = "depositRadioButtonS";
            this.depositRadioButtonS.Size = new System.Drawing.Size(61, 17);
            this.depositRadioButtonS.TabIndex = 0;
            this.depositRadioButtonS.TabStop = true;
            this.depositRadioButtonS.Text = "Deposit";
            this.depositRadioButtonS.UseVisualStyleBackColor = true;
            // 
            // exitButtonS
            // 
            this.exitButtonS.Location = new System.Drawing.Point(321, 191);
            this.exitButtonS.Name = "exitButtonS";
            this.exitButtonS.Size = new System.Drawing.Size(75, 23);
            this.exitButtonS.TabIndex = 12;
            this.exitButtonS.Text = "E&xit";
            this.exitButtonS.UseVisualStyleBackColor = true;
            this.exitButtonS.Click += new System.EventHandler(this.exitButtonS_Click);
            // 
            // myButtonS
            // 
            this.myButtonS.AutoSize = true;
            this.myButtonS.Location = new System.Drawing.Point(204, 191);
            this.myButtonS.Name = "myButtonS";
            this.myButtonS.Size = new System.Drawing.Size(97, 23);
            this.myButtonS.TabIndex = 11;
            this.myButtonS.Text = "Awesome &Button";
            this.myButtonS.UseVisualStyleBackColor = true;
            this.myButtonS.Click += new System.EventHandler(this.myButtonS_Click);
            // 
            // clearButtonS
            // 
            this.clearButtonS.Location = new System.Drawing.Point(110, 191);
            this.clearButtonS.Name = "clearButtonS";
            this.clearButtonS.Size = new System.Drawing.Size(75, 23);
            this.clearButtonS.TabIndex = 10;
            this.clearButtonS.Text = "C&lear";
            this.clearButtonS.UseVisualStyleBackColor = true;
            this.clearButtonS.Click += new System.EventHandler(this.clearButtonS_Click);
            // 
            // submitButtonS
            // 
            this.submitButtonS.Location = new System.Drawing.Point(17, 191);
            this.submitButtonS.Name = "submitButtonS";
            this.submitButtonS.Size = new System.Drawing.Size(75, 23);
            this.submitButtonS.TabIndex = 9;
            this.submitButtonS.Text = "S&ubmit";
            this.submitButtonS.UseVisualStyleBackColor = true;
            this.submitButtonS.Click += new System.EventHandler(this.submitButtonS_Click);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "ATM";
            this.Text = "ATM";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.transactionGroupBoxC.ResumeLayout(false);
            this.transactionGroupBoxC.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.transactionGroupBoxS.ResumeLayout(false);
            this.transactionGroupBoxS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox amountTextBoxC;
        private System.Windows.Forms.Label balanceLabelC;
        private System.Windows.Forms.Label balanceLabel2;
        private System.Windows.Forms.Label amountLabelC;
        private System.Windows.Forms.GroupBox transactionGroupBoxC;
        private System.Windows.Forms.RadioButton withdrawRadioButtonC;
        private System.Windows.Forms.RadioButton depositRadioButtonC;
        private System.Windows.Forms.Button exitButtonC;
        private System.Windows.Forms.Button myButtonC;
        private System.Windows.Forms.Button clearButtonC;
        private System.Windows.Forms.Button submitButtonC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox amountTextBoxS;
        private System.Windows.Forms.Label balanceLabelS;
        private System.Windows.Forms.Label balanceLabel4;
        private System.Windows.Forms.Label amountLabelS;
        private System.Windows.Forms.GroupBox transactionGroupBoxS;
        private System.Windows.Forms.RadioButton withdrawRadioButtonS;
        private System.Windows.Forms.RadioButton depositRadioButtonS;
        private System.Windows.Forms.Button exitButtonS;
        private System.Windows.Forms.Button myButtonS;
        private System.Windows.Forms.Button clearButtonS;
        private System.Windows.Forms.Button submitButtonS;
    }
}