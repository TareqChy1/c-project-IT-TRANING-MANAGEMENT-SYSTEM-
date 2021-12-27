using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITDbConnection
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        

        private void ManageEmployeeButton210_Click(object sender, EventArgs e)
        {
            
                    this.Hide();
                    ManageEmployee ma = new ManageEmployee();
                    ma.Show();

                
        }

        private void ChangePasswordButton29_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void ManageCourseButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCourse mc = new ManageCourse();
            mc.Show();
        }

        private void ManageStudentButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent ms = new ManageStudent();
            ms.Show();
        }

        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }
    }
}
