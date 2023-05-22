using DGVPrinterHelper;
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
    public partial class ViewVacationForm : Form
    {
        VacationClass vacation = new VacationClass();

        public ViewVacationForm()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = vacation.getList(command);
        }

        private void ViewVacationForm_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column4 = DataGridView_employee.Columns[4];
            column4.Width = 150;

            comboBox_job.DataSource = vacation.getList(new SqlCommand("SELECT DISTINCT [Сфера_деятельности] as [Сфера деятельности] FROM Должность"));
            comboBox_job.DisplayMember = "Сфера деятельности";
            comboBox_job.ValueMember = "Сфера деятельности";

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
            string job = comboBox_job.Text;

            if (type == "" && job == "")
            {
                DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
            }
            else if (type != "" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Тип LIKE '{type}'";
            }
            else if(type == "" && job != "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Сфера деятельности] LIKE '{job}'";
            }
            else if(type != "" && job != "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Тип LIKE '{type}' AND [Сфера деятельности] LIKE '{job}'";
            }
        }

        private void textBox_dur_TextChanged(object sender, EventArgs e)
        {
            if(textBox_dur.Text.Length == 0)
            {
                DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
            }
            else
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Длительность (в днях)] = {Convert.ToInt32(textBox_dur.Text)}";
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            DGVPrinter helper = new DGVPrinter();

            helper.Title = "Информация об Отпуске сотрудников ННГАСУ";
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
    }
}
