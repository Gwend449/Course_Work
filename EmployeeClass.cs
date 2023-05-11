using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    class EmployeeClass
    {
        DataBase dataBase = new DataBase();

        public bool insertEmployee(string name, string surname, string dadName, DateTime age, string gender, string address)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Сотрудник] ([Фамилия],[Имя],[Отчество],[Пол],[Возраст],[Адрес]) VALUES (@sn, @fn, @dn, @gn, @age, @adr)", dataBase.getConnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sn", SqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@dn", SqlDbType.VarChar).Value = dadName;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@age", SqlDbType.Date).Value = age;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }

        }

        public DataTable getEmployeeList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Сотрудник]", dataBase.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, dataBase.getConnection);
            dataBase.openConnection();
            string count = command.ExecuteScalar().ToString();
            dataBase.closeConnection();
            return count;
        }

        public string totalEmployees()
        {
            return exeCount("SELECT COUNT(*) FROM [Сотрудник]");
        }
        public string totalFemale()
        {
            return exeCount("SELECT COUNT(*) FROM [Сотрудник] Where [Пол] = 'Женщина'");
        }
        public string totalMale()
        {
            return exeCount("SELECT COUNT(*) FROM [Сотрудник] Where [Пол] = 'Мужчина'");
        }

        public DataTable searchEmployee(string search)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Сотрудник] WHERE CONCAT([Имя],[Фамилия],[Отчество]) LIKE '%"+search+"%'", dataBase.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateEmployee(int id, string name, string surname, string dadName, DateTime age, string gender, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE [Сотрудник] SET [Фамилия]=@sn, [Имя]=@fn, [Отчество]=@dn ,[Пол]=@gn,[Возраст]=@age ,[Адрес] = @adr WHERE Id = @id", dataBase.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id; ;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sn", SqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@dn", SqlDbType.VarChar).Value = dadName;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@age", SqlDbType.Date).Value = age;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }

        }

        public bool deleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Сотрудник] WHERE Id= @id", dataBase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            dataBase.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }
        }

        public DataTable getEmployeeList(SqlCommand command)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM [Сотрудник]", dataBase.getConnection);
            command.Connection = dataBase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
