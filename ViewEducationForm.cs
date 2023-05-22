using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class ViewEducationForm : Form
    {
        EducationClass education = new EducationClass();

        public ViewEducationForm()
        {
            InitializeComponent();
        }

        private void ViewEducationForm_Load(object sender, EventArgs e)
        {
            showEducation();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;

            comboBox_college.DataSource = education.getList(new SqlCommand("SELECT DISTINCT [Учебное_заведение] FROM Образование"));
            comboBox_college.DisplayMember = "Учебное_заведение";
            comboBox_college.ValueMember = "Учебное_заведение";

            comboBox_course.DataSource = education.getList(new SqlCommand("SELECT DISTINCT Направление FROM Образование"));
            comboBox_course.DisplayMember = "Направление";
            comboBox_course.ValueMember = "Направление";
        }

        private void showEducation()
        {
            DataGridView_employee.DataSource = education.getList(new SqlCommand("SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string course = comboBox_course.Text;
            string college = comboBox_college.Text;

            if (college != "" && course == "")
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id WHERE [Образование].[Учебное_заведение] = '{college}'"));

            }
            else if (college == "" && course == "")
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));

            }
            else if (college != "" && course != "")
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id WHERE [Образование].[Учебное_заведение] = '{college}' AND [Образование].[Направление] = '{course}'"));
            }
        }
    }
}
