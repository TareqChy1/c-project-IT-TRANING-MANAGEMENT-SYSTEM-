using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Framework;
using System.Data.SqlClient;
using System.Data;
using IT.Entities;


namespace IT.DataAccess
{
    public class loginData
    {
        public User getuser(String userId, string password)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from login WHERE UserId= '" + userId + "' and Password = '" + password + "'");
            User user = new User();
            user = GetData(cmd);
            return user;
        }

        User GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            User obj = new User();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.userId = reader.GetString(0);
                    obj.password = reader.GetString(1);
                    obj.activeStatus = reader.GetInt32(2);
                    obj.status = reader.GetInt32(3);

                }
                reader.Close();

            }
            cmd.Connection.Close();
            return obj;
        }
        public void UpdatePassword(string userId, string password)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE login SET password=@Password WHERE userId=@UserId");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public String SearchPassword(string userId)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT Password from login WHERE UserId='" + userId + "'");
            string Password = "";
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string c;
                    c = reader.GetString(0);

                    Password = c;
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return Password;
        }
        public void InsertUser(User user)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO login VALUES(@userid,@password,@activestatus,@status,@security)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userid", user.userId);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@activestatus", user.activeStatus);
            cmd.Parameters.AddWithValue("@status", user.status);
            //cmd.Parameters.AddWithValue("@security", user.Security);
           
            cmd.Connection.Open();


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }


        public void UpdateUser(string userId, string status)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE login SET activeStatus=@status WHERE userid=@userId");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Connection.Open();


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }



        
        

    }
}
    
