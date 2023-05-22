using DGVPrinterHelper;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class PrintVacation : Form
    {
        VacationClass vacation = new VacationClass();
        DGVPrinter helper = new DGVPrinter();

        public PrintVacation()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = vacation.getList(command);
        }

        private void showVacation()
        {
            DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
        }

        private void PrintVacation_Load(object sender, EventArgs e)
        {
            showVacation();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void printData()
        {
            helper.Title = "Информация об отпусках сотрудников ННГАСУ";
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

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_employee.DataSource = vacation.searchVacation(textBox_search.Text);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            string selectQuery;

            if (radioButton1.Checked)
            {
                selectQuery = "select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id";
            }
            else if (radioButton_FeMale.Checked)
            {
                selectQuery = "select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id WHERE Сотрудник.[Пол] = 'Женщина'";
            }
            else
            {
                selectQuery = "select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Должность.Сфера_деятельности as [Сфера деятельности], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Длительность (в днях)] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id Where Сотрудник.[Пол] = 'Мужчина'";
            }
            showData(new SqlCommand(selectQuery));
            printData();
        }
    }
}
