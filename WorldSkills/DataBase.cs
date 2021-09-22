using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WorldSkills
{
    class DataBase
    {
        string connectionString;
        SqlConnection connection;

        public void OpenConnection()
        {
            connectionString = @"Data Source=SQLDEM\SQLDEM;Initial Catalog=pr1-22-vodyannikoves_WorldSkills;"
            + "Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
