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
    public partial class PrintDegree : Form
    {
        JobActivityClass jobActivityClass = new JobActivityClass();
        DGVPrinter helper = new DGVPrinter();
        DegreeClass degree = new DegreeClass();

        public PrintDegree()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = jobActivityClass.getList(command);
        }

        private void showEmpDeg()
        {
            DataGridView_employee.DataSource = degree.getList(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
            
        }

        private void PrintDegree_Load(object sender, EventArgs e)
        {
            showEmpDeg();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void printData()
        {
            helper.Title = "Информация о Учёной степени сотрудников ННГАСУ";
            helper.SubTitle = string.Format("Date: (0)", DateTime.Now.Date);
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
            DataGridView_employee.DataSource = degree.searchDegree(textBox_search.Text);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            string selectQuery;

            if (radioButton1.Checked)
            {
                selectQuery = "select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень";
            }
            else if (radioButton_FeMale.Checked)
            {
                selectQuery = "select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень WHERE Сотрудник.[Пол] = 'Женщина'";
            }
            else
            {
                selectQuery = "select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень Where Сотрудник.[Пол] = 'Мужчина'";
            }
            showData(new SqlCommand(selectQuery));
            printData();
        }
    }
}
