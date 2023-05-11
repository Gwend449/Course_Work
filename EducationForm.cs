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
    public partial class EducationForm : Form
    {
        EmployeeClass employee = new EmployeeClass();
        EducationClass education = new EducationClass();

        public EducationForm()
        {
            InitializeComponent();
        }

        private void showEmployee()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand("SELECT Id, Имя, Фамилия, Отчество, Возраст FROM Сотрудник"));
        }
        private void showEducation()
        {
            DataGridView_employee.DataSource = education.getList(new SqlCommand("SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Отчество], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_empl.Visible = false;
            showEmployee();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            //DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            //column5.Width = 90;
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_empl_ID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker_empl.Value = (DateTime)DataGridView_employee.CurrentRow.Cells[4].Value;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_college.Clear();
            textBox_Course.Clear();
            textBox_empl_ID.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        bool verify()
        {
            if (textBox_college.Text == ""
                || textBox_Course.Text == "" || dateTimePicker1.Value == DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_empl_ID.Text == "")
            {
                MessageBox.Show("Требуется выбрать сотрудника", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int eID = Convert.ToInt32(textBox_empl_ID.Text);
                string institution = textBox_college.Text;
                DateTime date = dateTimePicker1.Value;
                string course = textBox_Course.Text;

                int born_year = dateTimePicker_empl.Value.Year;
                int this_year = DateTime.Now.Year;
                int grad_year = dateTimePicker1.Value.Year;

                if((this_year - born_year - 5) < (this_year - grad_year))
                {
                    MessageBox.Show("Высшее образование было получено менее 5 лет назад, проверьте введенные данные", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(verify())
                {
                    try
                    {
                        if (education.insetEducation(eID, institution, date, course))
                        {
                            showEducation();
                            button_clear.PerformClick();
                            MessageBox.Show("Информация об Образовании добавлена", "Образование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пустые поля", "Добавить образование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_empl_Click(object sender, EventArgs e)
        {
            showEmployee();
        }

        private void button_edct_Click(object sender, EventArgs e)
        {
            showEducation();
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.AllowUserToAddRows = false;
            DataGridView_employee.AllowUserToDeleteRows = false;
        }
    }
}
