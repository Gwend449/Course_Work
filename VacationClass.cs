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

        public bool checkVacation(int empID)
        {
            DataTable table = getList(new SqlCommand($"select * from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id WHERE Сотрудник.Id = {empID}"));
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkVacationn(int empID, DateTime startDate)
        {
            DataTable table = getList(new SqlCommand($"select * from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id WHERE Сотрудник.Id = {empID}"));
            if (table.Rows.Count > 1)
            {
                SqlCommand command = new SqlCommand($"SELECT Отпуск.Дата FROM Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника WHERE ds.Id = {empID}", dataBase.getConnection);
                SqlCommand command1 = new SqlCommand($"SELECT Отпуск.Длительность FROM Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника WHERE ds.Id = {empID}", dataBase.getConnection);
                dataBase.openConnection();
                var date = Convert.ToDateTime(command.ExecuteScalar().ToString());
                var dur = Convert.ToInt32(command1.ExecuteScalar().ToString());
                dataBase.closeConnection();

                var vacationEndDate = date.AddDays(dur);
                var newVacationDate = startDate;

                if (vacationEndDate > newVacationDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool checkVacationDuration(int empID, DateTime startDate)
        {
            SqlCommand command = new SqlCommand($"SELECT Отпуск.Дата FROM Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника WHERE ds.Id = {empID}", dataBase.getConnection);
            SqlCommand command1 = new SqlCommand($"SELECT Отпуск.Длительность FROM Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника WHERE ds.Id = {empID}", dataBase.getConnection);
            dataBase.openConnection();
            var date = Convert.ToDateTime(command.ExecuteScalar().ToString());
            var dur = Convert.ToInt32(command1.ExecuteScalar().ToString());
            dataBase.closeConnection();

            var vacationEndDate = date.AddDays(dur);
            var newVacationDate = startDate;

            if (vacationEndDate > newVacationDate)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public DataTable searchVacation(string search)
        {
            SqlCommand command = new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id WHERE CONCAT(Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество) LIKE '%" + search + "%'", dataBase.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
