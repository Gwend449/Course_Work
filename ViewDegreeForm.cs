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
            showData(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 70;

            comboBox_job.DataSource = jobActivity.getList(new SqlCommand("SELECT DISTINCT [Сфера_деятельности] as [Сфера деятельности] FROM Должность"));
            comboBox_job.DisplayMember = "Сфера деятельности";
            comboBox_job.ValueMember = "Сфера деятельности";

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
    }
}
