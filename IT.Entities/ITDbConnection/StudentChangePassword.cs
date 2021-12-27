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
    public partial class StudentChangePassword : Form
    {
        public StudentChangePassword()
        {
            InitializeComponent();
        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton21_Click(object sender, EventArgs e)
        {
            loginData l = new loginData();
            string c = l.SearchPassword(IdtextBox1.Text);

            if (CurrentPasswordtextBox2.Text == c)
            {
                loginData a = new loginData();
                a.UpdatePassword(IdtextBox1.Text, NewPasswordtextBox3.Text);
                MessageBox.Show("Password Updated", "Password change", MessageBoxButtons.OK);
                CurrentPasswordtextBox2.Clear();
                NewPasswordtextBox3.Clear();

            }
            else if (CurrentPasswordtextBox2.Text != c)
            {
                MessageBox.Show("Current Password Wrong", "Password Change", MessageBoxButtons.OK);
                CurrentPasswordtextBox2.Clear();
                NewPasswordtextBox3.Clear();
            }
        }

        private void LogOutButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void ExitButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s = new Student();
            s.Show();
        }

       
    }
}
