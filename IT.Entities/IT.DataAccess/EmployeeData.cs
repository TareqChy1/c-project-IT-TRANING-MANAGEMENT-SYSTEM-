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
    public class EmployeeData
    {

        public void InsertEmployee(Employeecs emp)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO employee VALUES(@employeeId,@employeeName,@email,@address,@designation,@salary,@gender,@phone,@age,@status)");
            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.AddWithValue("@employeeName", emp.EmployeeName);
            cmd.Parameters.AddWithValue("@email", emp.Email);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@designation", emp.Designation);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            cmd.Parameters.AddWithValue("@gender", emp.Gender);
            cmd.Parameters.AddWithValue("@phone", emp.Phone);
            cmd.Parameters.AddWithValue("@age", emp.Age);
            cmd.Parameters.AddWithValue("@status", emp.ActiveStatus);



            cmd.Connection.Open();


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }



        public  List<Employeecs> GetData(SqlCommand cmd)
            {
                     cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Employeecs> list = new List<Employeecs>();
                    using (reader)
                    {
                    while (reader.Read())
                    {
                    Employeecs obj = new Employeecs();
                  
                    
                    obj.EmployeeName = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Address = reader.GetString(3);
                    obj.Designation = reader.GetString(4);
                    obj.Salary = reader.GetFloat(5);
                    obj.Gender = reader.GetString(6);
                    obj.Phone = reader.GetInt32(7);
                    obj.Age = reader.GetInt32(8);
                    obj.ActiveStatus = reader.GetString(9);
                    list.Add(obj);
                    }
                    reader.Close();
                    }
                    cmd.Connection.Close();
                    return list;
          }

          public List<Employeecs> GetEmployeeList()
          {
              SqlDbDataAccess da = new SqlDbDataAccess();
              SqlCommand cmd = da.GetCommand("SELECT * from employee WHERE status=@status");
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@status", 3);
              List<Employeecs> employeeList = GetData(cmd);
              return employeeList;
          }

          public void DeleteEmployee(string Id)

          {

              SqlDbDataAccess da = new SqlDbDataAccess();
              SqlCommand cmd = da.GetCommand("UPDATE employee SET status=@status WHERE employeeId=@id");
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@id",Id);
              cmd.Parameters.AddWithValue("@status", 3);
              cmd.Connection.Open();


              cmd.ExecuteNonQuery();
              cmd.Connection.Close();


          }

        
    }
}




       
 
 
