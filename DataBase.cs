using System.Data.SqlClient;
using System.IO;
using System;
using System.Windows.Forms;

namespace Course_Work
{
    class DataBase
    {

        //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University_HR;Integrated Security=True");

        //public static string ReadCS()
        //{
        //    using (var sr = File.OpenText("conn.txt"))
        //    {
        //        var lines = sr.ReadLineAsync().Result;
        //        return lines;
        //    }
        //}

        //public static string ReadSecondWay()
        //{
        //    using (var fileStream = File.OpenRead("conn.txt"))
        //    {
        //        using (var reader = new StreamReader("conn.txt"))
        //        {
        //            var str = reader.ReadLine();
        //            return str;
        //        }
        //    }
        //}

        public static string getCS()
        {
            string fileName = "conn.txt";
            string cs = "";
            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        cs = sr.ReadToEnd();
                        sr.Dispose();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return cs;
        }



        SqlConnection connection = new SqlConnection(getCS());


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
