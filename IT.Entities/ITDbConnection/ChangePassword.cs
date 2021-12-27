using IT.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITDbConnection
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void SubmitButton21_Click(object sender, EventArgs e)
        {
            loginData l = new loginData();
            string c = l.SearchPassword(IdtextBox1.Text);

            if (CurrentPasswordtextBox1.Text == c)
            {
                loginData a = new loginData();
                a.UpdatePassword(IdtextBox1.Text, NewPasswordtextBox2.Text);
                MessageBox.Show("Password Updated", "Password change", MessageBoxButtons.OK);
                CurrentPasswordtextBox1.Clear();
                NewPasswordtextBox2.Clear();

            }
            else if (CurrentPasswordtextBox1.Text != c)
            {
                MessageBox.Show("Current Password Wrong", "Password Change", MessageBoxButtons.OK);
                CurrentPasswordtextBox1.Clear();
                NewPasswordtextBox2.Clear();
            }
            
        }

        private void BackButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IdtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
