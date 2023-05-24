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
    public partial class PrintJobActivity : Form
    {
        JobActivityClass jobActivityClass = new JobActivityClass();
        DGVPrinter helper = new DGVPrinter();

        public PrintJobActivity()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = jobActivityClass.getList(command);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            helper.Title = "Информация о Должностях сотрудников ННГАСУ";
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

        private void PrintJobActivity_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности] as [Должность], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 66;
            DataGridViewColumn column4 = DataGridView_employee.Columns[4];
            column4.Width = 53;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 50;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_employee.DataSource = jobActivityClass.searchJob(textBox_search.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string selectQuery;

            if (radioButton1.Checked)
            {
                selectQuery = "SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id";
            }
            else if (radioButton_FeMale.Checked)
            {
                selectQuery = "SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id WHERE Сотрудник.[Пол] = 'Женщина'";
            }
            else
            {
                selectQuery = "SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id Where Сотрудник.[Пол] = 'Мужчина'";
            }
            showData(new SqlCommand(selectQuery));
        }
    }
}
