using System;
using System.Data.SqlClient;

namespace Course_Work
{
    class DataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University_HR;Integrated Security=True");

        public SqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
