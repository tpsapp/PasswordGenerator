using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class frmMain : Form
    {
        string sNumbers = "0123456789";
        string sLLetters = "abcdefghijklmnopqrstuvwxyz";
        string sULetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string sSpecial = "!@#$%&*?";
        RegistryKey rkKey = Registry.CurrentUser;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                rkKey = Registry.CurrentUser.OpenSubKey(@"Software\SWPassGen");
                this.Top = System.Convert.ToInt32(rkKey.GetValue("loctop"));
                this.Left = System.Convert.ToInt32(rkKey.GetValue("locleft"));
                cbAutoCopy.Checked = System.Convert.ToBoolean(rkKey.GetValue("autocopy"));
                cbLLetters.Checked = System.Convert.ToBoolean(rkKey.GetValue("lowercase"));
                cbULetters.Checked = System.Convert.ToBoolean(rkKey.GetValue("uppercase"));
                cbNumbers.Checked = System.Convert.ToBoolean(rkKey.GetValue("numbers"));
                cbSpecial.Checked = System.Convert.ToBoolean(rkKey.GetValue("special"));
                nudLength.Value = System.Convert.ToInt32(rkKey.GetValue("length"));
            }
            catch (Exception ex)
            {
                rkKey = Registry.CurrentUser.CreateSubKey(@"Software\SWPassGen");
                rkKey.SetValue("loctop", this.Top);
                rkKey.SetValue("locleft", this.Left);
                rkKey.SetValue("autocopy", cbAutoCopy.Checked);
                rkKey.SetValue("lowercase", cbLLetters.Checked);
                rkKey.SetValue("uppercase", cbULetters.Checked);
                rkKey.SetValue("numbers", cbNumbers.Checked);
                rkKey.SetValue("special", cbSpecial.Checked);
                rkKey.SetValue("length", nudLength.Value);
            }
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            string sCharacters = "";
            String sPassword = null;

            if (cbNumbers.Checked)
            {
                sCharacters += sNumbers;
            }

            if (cbLLetters.Checked)
            {
                sCharacters += sLLetters;
            }

            if (cbULetters.Checked)
            {
                sCharacters += sULetters;
            }

            if (cbSpecial.Checked)
            {
                sCharacters += sSpecial;
            }

            if (sCharacters != "")
            {
                for (int i = 0; i < nudLength.Value; i++)
                {
                    sPassword += sCharacters[rNumber.Next(sCharacters.Length)];
                }

                tbPassword.Text = sPassword;

                if (cbAutoCopy.Checked)
                {
                    tbPassword.SelectAll();
                    tbPassword.Copy();
                }
            }
            else
            {
                MessageBox.Show("Please choose atleast one type of character to include in the password.", "No character types selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sappsworld.com");
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            tbPassword.SelectAll();
            tbPassword.Copy();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            rkKey = Registry.CurrentUser.OpenSubKey(@"Software\SWPassGen", true);
            rkKey.SetValue("loctop", this.Top);
            rkKey.SetValue("locleft", this.Left);
            rkKey.SetValue("autocopy", cbAutoCopy.Checked);
            rkKey.SetValue("lowercase", cbLLetters.Checked);
            rkKey.SetValue("uppercase", cbULetters.Checked);
            rkKey.SetValue("numbers", cbNumbers.Checked);
            rkKey.SetValue("special", cbSpecial.Checked);
            rkKey.SetValue("length", nudLength.Value);
        }
    }
}
