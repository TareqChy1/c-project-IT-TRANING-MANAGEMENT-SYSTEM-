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
using System.Data.SqlClient;
using IT.Framework;

namespace ITDbConnection
{
    public partial class StudentShowAllCourse : Form
    {
        public StudentShowAllCourse()
        {
            InitializeComponent();
        }

        private void BackButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s = new Student();
            s.Show();

        }

        private void LogOutButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();

        }

        private void StudentShowAllCourse_Load(object sender, EventArgs e)
        {
            GetCourseRecord();
        }

        private void GetCourseRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H342N60;Initial Catalog=ITDB;User ID=SA;Password=TareqFarhad");
            SqlCommand cmd = new SqlCommand("Select * From CourseTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            CoursedataGridView1.DataSource = dt;
        
        }
    }
}
