using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    class JobActivityClass
    {
        DataBase dataBase = new DataBase();
        int job_id;

        public DataTable getList(SqlCommand command)
        {
            command.Connection = dataBase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        //public void readId()
        //{
        //    using (SqlCommand command_select = new SqlCommand("SELECT Должность.Id FROM Должность", dataBase.getConnection))
        //    {
        //        using (SqlDataReader reader = command_select.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                job_id = reader[0].ToString();
        //            }
        //        }
        //    }
        //}

        public bool insertJob(string job, decimal money, int exp, string degree)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Должность] ([Сфера_деятельности], [Оклад], [Стаж], [Звание]) VALUES(@job, @sal, @exp, @deg)", dataBase.getConnection);

            command.Parameters.Add("@job", SqlDbType.NVarChar).Value = job;
            command.Parameters.Add("@sal", SqlDbType.Money).Value = money;
            command.Parameters.Add("@exp", SqlDbType.Int).Value = exp;
            command.Parameters.Add("@deg", SqlDbType.NVarChar).Value = degree;
            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                using (SqlCommand command_select = new SqlCommand("SELECT Должность.Id FROM Должность", dataBase.getConnection))
                {
                    using (SqlDataReader reader = command_select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            job_id = Convert.ToInt32(reader[0].ToString());                        
                        }
                    }
                }

                dataBase.closeConnection();
                return true;
            }
            else
            {
                dataBase.closeConnection();
                return false;
            }

        }

        public bool insertJobToEmpl(int emp_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Должность_сотрудника] (Должность, Сотрудник) VALUES (@job_id, @emp_id)", dataBase.getConnection);
            command.Parameters.Add("@job_id", SqlDbType.Int).Value = job_id;
            command.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
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

        public bool checkJob(int empID)
        {
            DataTable table = getList(new SqlCommand($"SELECT [Должность_сотрудника].Сотрудник, [Должность_сотрудника].Должность FROM [Должность_сотрудника] WHERE [Должность_сотрудника].Сотрудник={empID} AND [Должность_сотрудника].Должность={job_id}"));
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateJob(int jobId, string job, decimal money, int exp, string degree)
        {
            SqlCommand command = new SqlCommand("UPDATE Должность SET [Сфера_деятельности]=@job, Оклад=@sal, Стаж=@exp, Звание=@deg WHERE Id=@id", dataBase.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = jobId;
            command.Parameters.Add("@job", SqlDbType.NVarChar).Value = job;
            command.Parameters.Add("@sal", SqlDbType.Money).Value = money;
            command.Parameters.Add("@exp", SqlDbType.Int).Value = exp;
            command.Parameters.Add("@deg", SqlDbType.NVarChar).Value = degree;
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

        public bool deleteJob(int jobId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Должность Where Id = @id",dataBase.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = jobId;
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

        public bool deleteEmplJob(int jobId, int empId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Должность_сотрудника] WHERE Должность=@jobId AND Сотрудник=@empId", dataBase.getConnection);
            command.Parameters.Add("@jobId", SqlDbType.Int).Value = jobId;
            command.Parameters.Add("@empId", SqlDbType.Int).Value = empId;
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

        public DataTable searchJob(string search)
        {
            SqlCommand command = new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности], Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Сотрудник INNER JOIN [Должность_сотрудника] as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id WHERE CONCAT(Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество) LIKE '%" + search + "%'", dataBase.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

///
//Ассистент
//Декан факультета
//Начальник факультета
//Директор института
//Начальник института
//Доцент
//Заведующий кафедрой
//Начальник кафедры
//Заместитель начальника кафедры
//Профессор
//Преподаватель
//Старший преподаватель
///
