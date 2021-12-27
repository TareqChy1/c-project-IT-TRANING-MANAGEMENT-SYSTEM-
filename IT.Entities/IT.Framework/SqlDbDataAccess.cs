using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IT.Framework
{
    public class SqlDbDataAccess
    {
        const string ConnectiosnString = "Data Source=DESKTOP-H342N60;Initial Catalog=ITDB;User ID=SA;Password=TareqFarhad";
        public SqlCommand GetCommand(String query)
        {
            var connection = new SqlConnection(ConnectiosnString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }

    }
}
