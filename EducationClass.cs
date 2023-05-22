using System;
using System.Data;
using System.Data.SqlClient;

namespace Course_Work
{
    class EducationClass
    {
        DataBase dbConnect = new DataBase();

        public bool insetEducation(int id, string institution, DateTime dateGrad, string course)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Образование] ([Сотрудник], [Учебное_заведение], [Год_окончания], [Направление]) VALUES" +
                "(@eid, @inst, @date, @src)", dbConnect.getConnection);

            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@inst", SqlDbType.NVarChar).Value = institution;
            command.Parameters.Add("@date", SqlDbType.Date).Value = dateGrad;
            command.Parameters.Add("@src", SqlDbType.NVarChar).Value = course;

            dbConnect.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                dbConnect.closeConnection();
                return true;
            }
            else
            {
                dbConnect.closeConnection();
                return false;
            }
        }
        
        public DataTable getList(SqlCommand command)
        {
            command.Connection = dbConnect.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateEducation(int id, string institution, DateTime dateGrad, string course)
        {
            SqlCommand command = new SqlCommand("UPDATE [Образование] SET [Учебное_заведение]=@inst, [Год_окончания]=@date, [Направление]=@src WHERE Id=@eid", dbConnect.getConnection);

            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@inst", SqlDbType.NVarChar).Value = institution;
            command.Parameters.Add("@date", SqlDbType.Date).Value = dateGrad;
            command.Parameters.Add("@src", SqlDbType.NVarChar).Value = course;

            dbConnect.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dbConnect.closeConnection();
                return true;
            }
            else
            {
                dbConnect.closeConnection();
                return false;
            }
        }

        public bool deleteEducation(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Образование] WHERE [Id]= @id", dbConnect.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            dbConnect.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dbConnect.closeConnection();
                return true;
            }
            else
            {
                dbConnect.closeConnection();
                return false;
            }
        }

        public DataTable searchEducation(string search)
        {
            SqlCommand command = new SqlCommand("SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Сотрудник.Пол, Образование.[Учебное_заведение] as [Учебное заведение], Образование.Направление, Образование.[Год_окончания] as [Год окончания] FROM Сотрудник INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id WHERE CONCAT([Имя],[Фамилия],[Отчество]) LIKE '%" + search + "%'", dbConnect.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
