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
    public partial class DegreeForm : Form
    {
        DegreeClass degreeClass = new DegreeClass();
        DataBase dataBase = new DataBase();
        EmployeeClass employeeClass = new EmployeeClass();

        public DegreeForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_employee.DataSource = degreeClass.getList(new SqlCommand("SELECT Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера Деятельности], Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id WHERE DATALENGTH(Должность.Звание) > 0", dataBase.getConnection));
        }

        private void button_empl_Click(object sender, EventArgs e)
        {
            showTable();
            DataGridView_employee.ReadOnly = true;
        }

        private void showEmpDeg()
        {
            DataGridView_employee.DataSource = degreeClass.getList(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера Деятельности], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
        }

        private void button_edct_Click(object sender, EventArgs e)
        {
            showEmpDeg();
            DataGridView_employee.ReadOnly = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            showTable();
            DataGridView_employee.ReadOnly = false;
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {
            showTable();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_empId.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_empId.Clear();
            radioButton_Degree.Checked = false;
            radioButton_FeMale.Checked = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_empId.Text == "" && radioButton_Degree.Checked == false && radioButton_FeMale.Checked == false)
            {
                MessageBox.Show("Пожалуйста заполните пустые поля.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string degree = radioButton_Degree.Checked ? "Кандидат наук" : "Доктор наук";
                    //string degree = textBox1.Text;
                    int empId = Convert.ToInt32(textBox_empId.Text);

                    if (!degreeClass.checkDegree(empId))
                    {
                        if (degreeClass.insertDegree(degree) && degreeClass.insertDegToEmp(empId))
                        {
                            showEmpDeg();
                            MessageBox.Show("Информация о степени успешно добавлена.", "Добавить степень", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник уже имеет учёную степень.", "Добавить степень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Добавить степень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
