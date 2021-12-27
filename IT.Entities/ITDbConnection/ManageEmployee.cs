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
    public partial class ManageEmployee : Form
    {
        
        public ManageEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H342N60;Initial Catalog=ITDB;User ID=SA;Password=TareqFarhad");
        public int employeId;
        private void ExitButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void InserbunifuThinButton21_Click(object sender, EventArgs e)
        {
             SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO login VALUES(@userid,@password,@activestatus,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userid",IdtextBox1.Text);

            cmd.Parameters.AddWithValue("@password", PasswordtextBox1.Text);
            cmd.Parameters.AddWithValue("@activestatus", ActiveStatusradioButton2.Checked);
            cmd.Parameters.AddWithValue("@status", StatusradioButton1.Checked);
           
            cmd.Connection.Open();


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            if (Isvalid())
            {

                SqlCommand cm = new SqlCommand("INSERT INTO employee VALUES(@employeeId,@employeeName,@status,@password,@activeStatus)", con);
                cm.CommandType = CommandType.Text;
                cm.Parameters.AddWithValue("@employeeId", IdtextBox1.Text);
                cm.Parameters.AddWithValue("@employeeName", NametextBox1.Text);
                cm.Parameters.AddWithValue("@status", ActiveStatusradioButton2.Checked);
                cm.Parameters.AddWithValue("@password", PasswordtextBox1.Text);
                cm.Parameters.AddWithValue("@activeStatus", StatusradioButton1.Checked);
                con.Open();


                cm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee is sucessfully saved in DataBase", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecord();

            
                
                
            }

        }

        private bool Isvalid()
        {
            if (NametextBox1.Text == string.Empty)
            {
                MessageBox.Show("Employee Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        

        private void BackbunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void LogOutbunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }

        private void GetEmployeeRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * From employee", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            EmployeeRecorddataGridView1.DataSource = dt;

        }

        private void Passwordlabel1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshbunifuThinButton21_Click(object sender, EventArgs e)
        {
            IdtextBox1.Clear();
            NametextBox1.Clear();
            PasswordtextBox1.Clear();
            IdtextBox1.Focus();


        }

        private void EmployeeRecorddataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdtextBox1.Text = Convert.ToString(EmployeeRecorddataGridView1.SelectedRows[0].Cells[0].Value);
            NametextBox1.Text = EmployeeRecorddataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PasswordtextBox1.Text = EmployeeRecorddataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        

        
        }
        }

       

       
        
    
