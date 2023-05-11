using System;
using System.Data;
using System.Data.SqlClient;

namespace Course_Work
{
    class VacationClass
    {
        DataBase dataBase = new DataBase();

        public DataTable getList(SqlCommand command)
        {
            command.Connection = dataBase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool insertVacation(int emp_id, int duration, DateTime date, string type)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Отпуск] (Длительность, Дата, Тип, Должность_сотрудника) VALUES(@dur, @date, @type, @empid)", dataBase.getConnection);

            command.Parameters.Add("@dur", SqlDbType.Int).Value = duration;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@empid", SqlDbType.Int).Value = emp_id;
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

        public bool updateVacation(int vacID, int duration, DateTime date, string type)
        {
            SqlCommand command = new SqlCommand("UPDATE [Отпуск] SET Длительность=@dur, Дата=@date, Тип=@type WHERE Id = @id", dataBase.getConnection);
            command.Parameters.Add("@dur", SqlDbType.Int).Value = duration;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@id", SqlDbType.Int).Value = vacID;
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

        public bool deleteVacation(int vacID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Отпуск] WHERE Id=@id", dataBase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = vacID;
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
    }
}
