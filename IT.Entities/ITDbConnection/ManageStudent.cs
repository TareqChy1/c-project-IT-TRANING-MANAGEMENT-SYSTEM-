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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H342N60;Initial Catalog=ITDB;User ID=SA;Password=TareqFarhad");
        public int studentId;

        private void InsertButton_Click(object sender, EventArgs e)
        {
            
            if (Isvalid())
            {

                SqlCommand cm = new SqlCommand("INSERT INTO StudentTable VALUES(@studentName,@password,@status,@activeStatus)", con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@studentName", StudentNametextBox1.Text);
                cm.Parameters.AddWithValue("@password", PasswordtextBox2.Text);
                cm.Parameters.AddWithValue("@status", StatusradioButton1.Checked);
                cm.Parameters.AddWithValue("@activeStatus", StatusradioButton1.Checked);

                con.Open();


                cm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is sucessfully added in DataBase", "added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();



            }


        }

        private bool Isvalid()
        {
            if (StudentNametextBox1.Text == string.Empty)
            {
                MessageBox.Show("Student Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void UpdateButton22_Click(object sender, EventArgs e)
        {
            if (studentId > 0)
            {
                SqlCommand cm = new SqlCommand("UPDATE StudentTable SET studentName=@studentName,password=@password,status=@status,activeStatus=@activeStatus WHERE studentId=@studentId", con);
                
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@studentName", StudentNametextBox1.Text);
                cm.Parameters.AddWithValue("@password", PasswordtextBox2.Text);
                cm.Parameters.AddWithValue("@status", StatusradioButton1.Checked);
                cm.Parameters.AddWithValue("@activeStatus", StatusradioButton1.Checked);
                cm.Parameters.AddWithValue("@studentId", this.studentId);

                con.Open();


                cm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Student is sucessfully updated in DataBase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
            }
            else
            {
                MessageBox.Show(" Please Update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetStudentRecord()
        
            
        {
            SqlCommand cmd = new SqlCommand("Select * From StudentTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentdataGridView1.DataSource = dt;
        }

        private void RemoveButton23_Click(object sender, EventArgs e)
        {
            if (studentId > 0)
            {
                SqlCommand cm = new SqlCommand("DELETE FROM StudentTable WHERE studentId=@studentId", con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@studentId", this.studentId);

                con.Open();


                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student is deleted from system", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                StudentNametextBox1.Clear();
                PasswordtextBox2.Clear();

            }
            else
            {
                MessageBox.Show("Please select a student to delete", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void BackButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void LogOutButton25_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void RefreshbunifuThinButton21_Click(object sender, EventArgs e)
        {
            studentId = 0;
            StudentNametextBox1.Clear();
            PasswordtextBox2.Clear();
            
             StudentNametextBox1.Focus();
        }

        private void StudentdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentId = Convert.ToInt32(StudentdataGridView1.SelectedRows[0].Cells[0].Value);
            StudentNametextBox1.Text = StudentdataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PasswordtextBox2.Text = StudentdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
