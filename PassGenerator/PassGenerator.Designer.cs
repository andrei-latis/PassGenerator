namespace PassGenerator
{
    partial class PassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGenerator));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkLowercaseCharacters = new System.Windows.Forms.CheckBox();
            this.cmbPasswordLength = new System.Windows.Forms.ComboBox();
            this.chkUppercaseCharacters = new System.Windows.Forms.CheckBox();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblLowercaseCharacters = new System.Windows.Forms.Label();
            this.lblUppercaseCharacters = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(47, 15);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(97, 36);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(47, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSymbols.Location = new System.Drawing.Point(190, 3);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(107, 24);
            this.chkSymbols.TabIndex = 2;
            this.chkSymbols.Text = "( @#$%&!? )";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Enabled = false;
            this.chkNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbers.Location = new System.Drawing.Point(190, 33);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(100, 24);
            this.chkNumbers.TabIndex = 3;
            this.chkNumbers.Text = "( 123456 )";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkLowercaseCharacters
            // 
            this.chkLowercaseCharacters.AutoSize = true;
            this.chkLowercaseCharacters.Checked = true;
            this.chkLowercaseCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercaseCharacters.Enabled = false;
            this.chkLowercaseCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowercaseCharacters.Location = new System.Drawing.Point(190, 63);
            this.chkLowercaseCharacters.Name = "chkLowercaseCharacters";
            this.chkLowercaseCharacters.Size = new System.Drawing.Size(104, 24);
            this.chkLowercaseCharacters.TabIndex = 4;
            this.chkLowercaseCharacters.Text = "( abcdefg )";
            this.chkLowercaseCharacters.UseVisualStyleBackColor = true;
            // 
            // cmbPasswordLength
            // 
            this.cmbPasswordLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPasswordLength.FormattingEnabled = true;
            this.cmbPasswordLength.Items.AddRange(new object[] {
            "4",
            "8",
            "12",
            "16",
            "20",
            "28",
            "36",
            "44",
            "52",
            "68",
            "84",
            "100",
            "116"});
            this.cmbPasswordLength.Location = new System.Drawing.Point(26, 64);
            this.cmbPasswordLength.Name = "cmbPasswordLength";
            this.cmbPasswordLength.Size = new System.Drawing.Size(132, 28);
            this.cmbPasswordLength.TabIndex = 6;
            // 
            // chkUppercaseCharacters
            // 
            this.chkUppercaseCharacters.AutoSize = true;
            this.chkUppercaseCharacters.Checked = true;
            this.chkUppercaseCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercaseCharacters.Enabled = false;
            this.chkUppercaseCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUppercaseCharacters.Location = new System.Drawing.Point(190, 93);
            this.chkUppercaseCharacters.Name = "chkUppercaseCharacters";
            this.chkUppercaseCharacters.Size = new System.Drawing.Size(125, 24);
            this.chkUppercaseCharacters.TabIndex = 7;
            this.chkUppercaseCharacters.Text = "( ABCDEFG )";
            this.chkUppercaseCharacters.UseVisualStyleBackColor = true;
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbols.Location = new System.Drawing.Point(12, 4);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(73, 20);
            this.lblSymbols.TabIndex = 8;
            this.lblSymbols.Text = "Symbols:";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(12, 34);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(77, 20);
            this.lblNumbers.TabIndex = 9;
            this.lblNumbers.Text = "Numbers:";
            // 
            // lblLowercaseCharacters
            // 
            this.lblLowercaseCharacters.AutoSize = true;
            this.lblLowercaseCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowercaseCharacters.Location = new System.Drawing.Point(12, 64);
            this.lblLowercaseCharacters.Name = "lblLowercaseCharacters";
            this.lblLowercaseCharacters.Size = new System.Drawing.Size(172, 20);
            this.lblLowercaseCharacters.TabIndex = 10;
            this.lblLowercaseCharacters.Text = "Lowercase Characters:";
            // 
            // lblUppercaseCharacters
            // 
            this.lblUppercaseCharacters.AutoSize = true;
            this.lblUppercaseCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppercaseCharacters.Location = new System.Drawing.Point(11, 94);
            this.lblUppercaseCharacters.Name = "lblUppercaseCharacters";
            this.lblUppercaseCharacters.Size = new System.Drawing.Size(173, 20);
            this.lblUppercaseCharacters.TabIndex = 11;
            this.lblUppercaseCharacters.Text = "Uppercase Characters:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSymbols);
            this.panel1.Controls.Add(this.lblNumbers);
            this.panel1.Controls.Add(this.chkUppercaseCharacters);
            this.panel1.Controls.Add(this.lblUppercaseCharacters);
            this.panel1.Controls.Add(this.lblLowercaseCharacters);
            this.panel1.Controls.Add(this.chkLowercaseCharacters);
            this.panel1.Controls.Add(this.chkSymbols);
            this.panel1.Controls.Add(this.chkNumbers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 129);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPasswordLength);
            this.panel2.Controls.Add(this.cmbPasswordLength);
            this.panel2.Location = new System.Drawing.Point(337, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 129);
            this.panel2.TabIndex = 14;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLength.Location = new System.Drawing.Point(22, 33);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(136, 20);
            this.lblPasswordLength.TabIndex = 18;
            this.lblPasswordLength.Text = "Password Length:";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(3, 4);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ReadOnly = true;
            this.txbPassword.Size = new System.Drawing.Size(311, 103);
            this.txbPassword.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Location = new System.Drawing.Point(337, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 112);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txbPassword);
            this.panel4.Location = new System.Drawing.Point(12, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 112);
            this.panel4.TabIndex = 17;
            // 
            // PassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 271);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PassGenerator";
            this.Text = "PassGenerator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLowercaseCharacters;
        private System.Windows.Forms.ComboBox cmbPasswordLength;
        private System.Windows.Forms.CheckBox chkUppercaseCharacters;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblLowercaseCharacters;
        private System.Windows.Forms.Label lblUppercaseCharacters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPasswordLength;
    }
}