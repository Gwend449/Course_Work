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
    public partial class ViewJobActivityForm : Form
    {
        JobActivityClass jobActivity = new JobActivityClass();

        public ViewJobActivityForm()
        {
            InitializeComponent();
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = jobActivity.getList(command);
        }

        private void ViewJobActivityForm_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности] as [Сфера Деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 35;

            comboBox_job.DataSource = jobActivity.getList(new SqlCommand("SELECT DISTINCT [Сфера_деятельности] as [Сфера деятельности] FROM Должность"));
            comboBox_job.DisplayMember = "Сфера деятельности";
            comboBox_job.ValueMember = "Сфера деятельности";

            comboBox_title.DataSource = jobActivity.getList(new SqlCommand("SELECT DISTINCT Звание FROM Должность"));
            comboBox_title.DisplayMember = "Звание";
            comboBox_title.ValueMember = "Звание";

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //int exp = Convert.ToInt32(textBox_exp);
            string title = comboBox_title.Text;
            string job = comboBox_job.Text;

            if(title == "" && job == "")
            {
                DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности] as [Сфера Деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
            }
            else if(job!="" && title == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Сфера Деятельности] LIKE '{job}'";
            }
            else if(title!="" && job == "")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Звание] LIKE '{title}'";
            }
            else if(title!="" && job!="")
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"[Сфера Деятельности] LIKE '{job}' AND [Звание] LIKE '{title}'";
            }
        }

        private void textBox_exp_TextChanged(object sender, EventArgs e)
        {
            if (textBox_exp.Text.Length == 0)
            {
                DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности] as [Сфера Деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
            }
            else
            {
                (DataGridView_employee.DataSource as DataTable).DefaultView.RowFilter = $"Стаж = {Convert.ToInt32(textBox_exp.Text)}";
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            DGVPrinter helper = new DGVPrinter();

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
    }
}
