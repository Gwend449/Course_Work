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
    public partial class ManageDegreeForm : Form
    {
        DegreeClass degreeClass = new DegreeClass();

        public ManageDegreeForm()
        {
            InitializeComponent();
        }

        private void ManageDegreeForm_Load(object sender, EventArgs e)
        {
            showEmpDeg();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void showEmpDeg()
        {
            DataGridView_employee.DataSource = degreeClass.getList(new SqlCommand("select Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Сфера Деятельности],Степень.Id as [Id (степень)], Степень.Степень, Должность.Звание FROM Сотрудник INNER JOIN Должность_сотрудника as DS ON DS.Сотрудник = Сотрудник.Id INNER JOIN Должность ON DS.Должность = Должность.Id INNER JOIN Степень_сотрудника as SS ON SS.Сотрудник = Сотрудник.Id INNER JOIN Степень ON Степень.Id = SS.Степень"));
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_empId.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = DataGridView_employee.CurrentRow.Cells[5].Value.ToString();
            string degree = DataGridView_employee.CurrentRow.Cells[6].Value.ToString();
            if (DataGridView_employee.CurrentRow.Cells[6].FormattedValue.Equals("Кандидат наук"))
            {
                radioButton_Degree.Checked = true;
                radioButton_FeMale.Checked = false;
            }
            else
            {
                radioButton_Degree.Checked = false;
                radioButton_FeMale.Checked = true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox_empId.Clear();
            radioButton_Degree.Checked = false;
            radioButton_FeMale.Checked = false;
        }

        private void button_Обновить_Click(object sender, EventArgs e)
        {
            if(textBox_empId.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Выберите сотрудника из списка.", "Обновить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int degId = Convert.ToInt32(textBox1.Text);
                    string degree = radioButton_Degree.Checked ? "Кандидат наук" : "Доктор наук";
                    if (degreeClass.updateDegree(degId, degree))
                    {
                        showEmpDeg();
                        MessageBox.Show("Данные о степени сотрудника успешно изменены!", "Обновить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Обновить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите сотрудника из списка.", "Обновить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    int empId = Convert.ToInt32(textBox_empId.Text);
                    int degId = Convert.ToInt32(textBox1.Text);
                    if (MessageBox.Show("Вы уверены что хотите удалить информацию о степени сотрудника?", "Удалить данные", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (degreeClass.deleteDegEmp(degId, empId))
                        {
                            degreeClass.deleteDegree(degId);
                            showEmpDeg();
                            MessageBox.Show("Данные о степени сотрудника успешно удалены", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
