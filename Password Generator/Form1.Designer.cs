namespace Password_Generator
{
    partial class frmMain
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
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.cbAutoCopy = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbULetters = new System.Windows.Forms.CheckBox();
            this.cbLLetters = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.nudLength);
            this.gbOptions.Controls.Add(this.cbAutoCopy);
            this.gbOptions.Controls.Add(this.cbSpecial);
            this.gbOptions.Controls.Add(this.cbULetters);
            this.gbOptions.Controls.Add(this.cbLLetters);
            this.gbOptions.Controls.Add(this.cbNumbers);
            this.gbOptions.Location = new System.Drawing.Point(12, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(145, 163);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Length:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(55, 134);
            this.nudLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(41, 20);
            this.nudLength.TabIndex = 5;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cbAutoCopy
            // 
            this.cbAutoCopy.AutoSize = true;
            this.cbAutoCopy.Location = new System.Drawing.Point(6, 111);
            this.cbAutoCopy.Name = "cbAutoCopy";
            this.cbAutoCopy.Size = new System.Drawing.Size(134, 17);
            this.cbAutoCopy.TabIndex = 4;
            this.cbAutoCopy.Text = "Auto-Copy to Clipboard";
            this.cbAutoCopy.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Location = new System.Drawing.Point(6, 88);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(115, 17);
            this.cbSpecial.TabIndex = 3;
            this.cbSpecial.Text = "Special Characters";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // cbULetters
            // 
            this.cbULetters.AutoSize = true;
            this.cbULetters.Location = new System.Drawing.Point(6, 65);
            this.cbULetters.Name = "cbULetters";
            this.cbULetters.Size = new System.Drawing.Size(113, 17);
            this.cbULetters.TabIndex = 2;
            this.cbULetters.Text = "Uppercase Letters";
            this.cbULetters.UseVisualStyleBackColor = true;
            // 
            // cbLLetters
            // 
            this.cbLLetters.AutoSize = true;
            this.cbLLetters.Checked = true;
            this.cbLLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLLetters.Location = new System.Drawing.Point(6, 42);
            this.cbLLetters.Name = "cbLLetters";
            this.cbLLetters.Size = new System.Drawing.Size(113, 17);
            this.cbLLetters.TabIndex = 1;
            this.cbLLetters.Text = "Lowercase Letters";
            this.cbLLetters.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Location = new System.Drawing.Point(6, 19);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(68, 17);
            this.cbNumbers.TabIndex = 0;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(163, 12);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(107, 36);
            this.bGenerate.TabIndex = 6;
            this.bGenerate.Text = "Generate Password";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(163, 54);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(107, 23);
            this.bCopy.TabIndex = 7;
            this.bCopy.Text = "Copy to Clipboard";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(12, 181);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(258, 20);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 59);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sappsworld Password Generator v1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(163, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.sappsworld.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.bGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 213);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.gbOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sappsworld Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox cbAutoCopy;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbULetters;
        private System.Windows.Forms.CheckBox cbLLetters;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

