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
    public partial class ManageCourse : Form
    {
        public ManageCourse()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H342N60;Initial Catalog=ITDB;User ID=SA;Password=TareqFarhad");
        public int courseId;



        private void InsertbunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {

                SqlCommand cm = new SqlCommand("INSERT INTO CourseTable VALUES(@courseName,@courseFee,@duration)", con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@courseName", CourseNametextBox2.Text);
                cm.Parameters.AddWithValue("@courseFee", CourseFeetextBox3.Text);
                cm.Parameters.AddWithValue("@duration", DurationtextBox4.Text);

                con.Open();


                cm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Course is sucessfully saved in DataBase", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCourseRecord();
            
                
                
            }

        }

        private bool Isvalid()
        {
            if (CourseNametextBox2.Text == string.Empty)
            {
                MessageBox.Show("Course Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }


        private void UpdatebunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(courseId > 0)
            {
                SqlCommand cm = new SqlCommand("UPDATE CourseTable SET courseName=@courseName,courseFee=@courseFee,duration=@duration WHERE courseId=@courseId", con);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@courseName", CourseNametextBox2.Text);
            cm.Parameters.AddWithValue("@courseFee", CourseFeetextBox3.Text);
            cm.Parameters.AddWithValue("@duration", DurationtextBox4.Text);
            cm.Parameters.AddWithValue("@courseId", this.courseId);
            
            con.Open();


            cm.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" Course is sucessfully updated in DataBase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetCourseRecord();
        }
            else
            {
                MessageBox.Show(" Please A course To Update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BackbunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutbunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            GetCourseRecord();

        }

        private void GetCourseRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * From CourseTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            coursedataGridView1.DataSource = dt;
        }

        private void ResetbunifuThinButton21_Click(object sender, EventArgs e)
        {
            courseId = 0;
            CourseNametextBox2.Clear();
            CourseFeetextBox3.Clear();
            DurationtextBox4.Clear();
            CourseNametextBox2.Focus();
        }

        private void coursedataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseId = Convert.ToInt32(coursedataGridView1.SelectedRows[0].Cells[0].Value);
            CourseNametextBox2.Text = coursedataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CourseFeetextBox3.Text = coursedataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DurationtextBox4.Text = coursedataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void deletebunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (courseId > 0)
            {
                SqlCommand cm = new SqlCommand("DELETE FROM CourseTable WHERE courseId=@courseId", con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@courseId", this.courseId);
                
                con.Open();


                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Course is deleted from system", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCourseRecord();
                CourseNametextBox2.Clear();
                CourseFeetextBox3.Clear();
                DurationtextBox4.Clear();
            }
            else{
                MessageBox.Show("Please select a course to delete", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
    }

