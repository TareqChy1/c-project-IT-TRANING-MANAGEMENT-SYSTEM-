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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeChangePassword emp = new EmployeeChangePassword();
            emp.Show();
        }

        

        

        private void ExitButton24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton25_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }



        public string EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }
    }
}
