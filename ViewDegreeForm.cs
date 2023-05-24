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
    public partial class ViewDegreeForm : Form
    {
        DegreeClass degree = new DegreeClass();
        JobActivityClass jobActivity = new JobActivityClass();

        public ViewDegreeForm()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = degree.getList(command);
        }

        private void ViewDegreeForm_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Должность],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 75;

            comboBox_job.DataSource = jobActivity.getList(new SqlCommand("SELECT DISTINCT [Сфера_деятельности] as [Должность] FROM Должность"));
            comboBox_job.DisplayMember = "Должность";
            comboBox_job.ValueMember = "Должность";

            comboBox_title.DataSource = jobActivity.getList(new SqlCommand("SELECT DISTINCT Звание FROM Должность"));
            comboBox_title.DisplayMember = "Звание";
            comboBox_title.ValueMember = "Звание";

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string deg = comboBox_degree.Text;
            string title = comboBox_title.Text;
            string job = comboBox_job.Text;

            if (deg == "" && title == "" && job == "")
            {
                DataGridView_employee.DataSource = degree.getList(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
            }
            else if (deg != "" && title == "" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Степень LIKE '{deg}'";
            }
            else if (deg == "" && title != "" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Звание LIKE '{title}'";
            }
            else if (deg == "" && title == "" && job != "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Сфера деятельности] LIKE '{job}'";
            }
            else if (deg != "" && title != "" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Степень LIKE '{deg}' AND Звание LIKE '{title}";
            }
            else if(deg != "" && title == "" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Степень LIKE '{deg}' AND [Сфера деятельности] LIKE '{job}'";
            }
            else if(deg == "" && title != "" && job != "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Звание LIKE '{title}' AND [Сфера деятельности] LIKE '{job}'";
            }
            else if(deg != "" && title != "" && job != "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Степень LIKE '{deg}' AND Звание LIKE '{title}' AND [Сфера деятельности] LIKE '{job}'";
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            DGVPrinter helper = new DGVPrinter();

            helper.Title = "Информация о Учёной степени сотрудников ННГАСУ";
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
            if (textBox_search.Text.Length == 0)
            {
                DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности] as [Должность], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
            }
            else
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{textBox_search.Text}%' OR Фамилия LIKE '%{textBox_search.Text}%' OR Отчество LIKE '%{textBox_search.Text}%'";
            }
        }
    }
}
