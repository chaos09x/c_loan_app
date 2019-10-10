namespace Project9A
{
    partial class Form2
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
            this.addButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerCheckBox = new System.Windows.Forms.CheckBox();
            this.loanCheckBox = new System.Windows.Forms.CheckBox();
            this.accountCheckBox = new System.Windows.Forms.CheckBox();
            this.loanListBox = new System.Windows.Forms.ListBox();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(246, 539);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(327, 539);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 1;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(408, 539);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(489, 539);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(570, 539);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.AutoSize = true;
            this.customerCheckBox.Location = new System.Drawing.Point(57, 12);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(75, 17);
            this.customerCheckBox.TabIndex = 5;
            this.customerCheckBox.Text = "Customers";
            this.customerCheckBox.UseVisualStyleBackColor = true;
            // 
            // loanCheckBox
            // 
            this.loanCheckBox.AutoSize = true;
            this.loanCheckBox.Location = new System.Drawing.Point(263, 12);
            this.loanCheckBox.Name = "loanCheckBox";
            this.loanCheckBox.Size = new System.Drawing.Size(55, 17);
            this.loanCheckBox.TabIndex = 6;
            this.loanCheckBox.Text = "Loans";
            this.loanCheckBox.UseVisualStyleBackColor = true;
            // 
            // accountCheckBox
            // 
            this.accountCheckBox.AutoSize = true;
            this.accountCheckBox.Location = new System.Drawing.Point(484, 12);
            this.accountCheckBox.Name = "accountCheckBox";
            this.accountCheckBox.Size = new System.Drawing.Size(71, 17);
            this.accountCheckBox.TabIndex = 7;
            this.accountCheckBox.Text = "Accounts";
            this.accountCheckBox.UseVisualStyleBackColor = true;
            // 
            // loanListBox
            // 
            this.loanListBox.FormattingEnabled = true;
            this.loanListBox.Location = new System.Drawing.Point(201, 35);
            this.loanListBox.Name = "loanListBox";
            this.loanListBox.Size = new System.Drawing.Size(185, 160);
            this.loanListBox.TabIndex = 8;
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(17, 35);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(164, 160);
            this.customerListBox.TabIndex = 9;
            // 
            // accountListBox
            // 
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.Location = new System.Drawing.Point(405, 35);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(240, 160);
            this.accountListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "To add data to the database, enter info in the textbox";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(17, 265);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerTextBox.TabIndex = 12;
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(201, 265);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(100, 20);
            this.loanTextBox.TabIndex = 13;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(405, 265);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountTextBox.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 574);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountListBox);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.loanListBox);
            this.Controls.Add(this.accountCheckBox);
            this.Controls.Add(this.loanCheckBox);
            this.Controls.Add(this.customerCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form2";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox customerCheckBox;
        private System.Windows.Forms.CheckBox loanCheckBox;
        private System.Windows.Forms.CheckBox accountCheckBox;
        private System.Windows.Forms.ListBox loanListBox;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
    }
}