using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT.Entities;
using IT.DataAccess;

namespace ITDbConnection
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            PasswordtextBox.PasswordChar = '*';
        }

 
       
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginData lg = new loginData();
            User user = lg.getuser(UserIDtextBox.Text,PasswordtextBox.Text);
            if (user != null)
            {
                if (user.activeStatus == 1 && user.status == 0)
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();

                }
                else if (user.activeStatus == 1 && user.status == 3)
                {
                    this.Hide();
                    Employee admin = new Employee();
                    admin.Show();

                }
                else if (user.activeStatus == 1 && user.status == 2)
                {
                    this.Hide();
                    Student s = new Student();
                    s.Show();

                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password", "login failed", MessageBoxButtons.OK);
                    UserIDtextBox.Clear();
                    PasswordtextBox.Clear();

                }
            }
        }

       

        private void ShowAllCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllCourse sh = new ShowAllCourse();
            sh.Show();
        }

       
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowcheckBox1.Checked)
            {
                PasswordtextBox.UseSystemPasswordChar = true;

            }

            else
            {
                PasswordtextBox.UseSystemPasswordChar = false;
            }

        }

        private void UserIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        

        
     

        
    }
}
