using System;
using System.Data;
using System.Data.SqlClient;

namespace Course_Work
{
    class DegreeClass
    {
        DataBase dataBase = new DataBase();

        public DataTable getList(SqlCommand command)
        {
            command.Connection = dataBase.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        int degId;

        public bool insertDegree(string degree)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Степень (Степень) VALUES(@deg)", dataBase.getConnection);

            command.Parameters.Add("@deg", SqlDbType.NVarChar).Value = degree;
            dataBase.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                using(SqlCommand command1 = new SqlCommand("SELECT Степень.Id FROM Степень", dataBase.getConnection))
                {
                    using(SqlDataReader reader = command1.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            degId = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                }
                dataBase.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkDegree(int empId)
        {
            DataTable table = getList(new SqlCommand($"select * from Степень INNER JOIN [Степень_сотрудника] as SS ON ss.Степень = Степень.Id INNER JOIN Сотрудник ON Сотрудник.Id = SS.Сотрудник WHERE Сотрудник.Id = {empId}"));

            if(table.Rows.Count>0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool insertDegToEmp(int empId)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Степень_сотрудника] (Степень, Сотрудник) VALUES (@degId, @empId)", dataBase.getConnection);
            command.Parameters.Add("@degId", SqlDbType.Int).Value = degId;
            command.Parameters.Add("@empId", SqlDbType.Int).Value = empId;
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

        public bool updateDegree(int degId, string deg)
        {
            SqlCommand command = new SqlCommand("UPDATE Степень SET [Степень]=@deg WHERE Id = @degId", dataBase.getConnection);
            command.Parameters.Add("@deg", SqlDbType.NVarChar).Value = deg;
            command.Parameters.Add("@degId", SqlDbType.Int).Value = degId;
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

        public bool deleteDegree(int degId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Степень Where Id= @id",dataBase.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = degId;
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

        public bool deleteDegEmp(int degId, int empId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Степень_сотрудника] WHERE Степень = @degId AND Сотрудник = @empId", dataBase.getConnection);
            command.Parameters.Add("@degId", SqlDbType.Int).Value = degId;
            command.Parameters.Add("@empId", SqlDbType.Int).Value = empId;
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

        public DataTable searchDegree(string search)
        {
            SqlCommand command = new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень WHERE CONCAT(Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество) LIKE '%" + search + "%'", dataBase.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
