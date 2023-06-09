﻿using DGVPrinterHelper;
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

            if (college != "" && course == "" && textBox_search.Text.Length == 0)
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id WHERE [Образование].[Учебное_заведение] = '{college}'"));

            }
            else if (college == "" && course == "" && textBox_search.Text.Length == 0)
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));

            }
            else if (college != "" && course != "" && textBox_search.Text.Length == 0)
            {
                DataGridView_employee.DataSource = education.getList(new SqlCommand($"SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id WHERE [Образование].[Учебное_заведение] = '{college}' AND [Образование].[Направление] = '{course}'"));
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            DGVPrinter helper = new DGVPrinter();

            helper.Title = "Информация об Образовании сотрудников ННГАСУ";
            helper.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            helper.SubTitleFormatFlags = StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;
            helper.PageNumbers = true;
            helper.PageNumberInHeader = false;
            helper.PorportionalColumns = true;
            helper.HeaderCellAlignment = StringAlignment.Near;
            helper.Footer = "NNGASU";
            helper.FooterSpacing = 15;
            helper.printDocument.DefaultPageSettings.Landscape = true;
            helper.PrintDataGridView(DataGridView_employee);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            JobActivityClass jobActivity = new JobActivityClass();
            if (textBox_search.Text.Length == 0)
            {
                DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Сотрудник].[Возраст], [Сотрудник].[Адрес], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));
            }
            else
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{textBox_search.Text}%' OR Фамилия LIKE '%{textBox_search.Text}%' OR Отчество LIKE '%{textBox_search.Text}%'";
            }
        }
    }
}
