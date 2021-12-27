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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void ShowAllCourseButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentShowAllCourse sa = new StudentShowAllCourse();
            sa.Show();
        }

       

        private void ChangePasswordButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentChangePassword sc = new StudentChangePassword();
            sc.Show();
        }

       

        private void LogOutButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
