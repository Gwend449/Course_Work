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
    public partial class ManageEducationForm : Form
    {
        EmployeeClass employee = new EmployeeClass();
        EducationClass education = new EducationClass();

        public ManageEducationForm()
        {
            InitializeComponent();
        }

        private void ManageEducationForm_Load(object sender, EventArgs e)
        {
            DataGridView_employee.ReadOnly = false;
            showEducation();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void showEmployee()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand("SELECT Id, Имя, Фамилия, Отчество, Возраст FROM Сотрудник"));
        }
        private void showEducation()
        {
            DataGridView_employee.DataSource = education.getList(new SqlCommand("SELECT [Образование].Id, [Сотрудник].[Имя], [Сотрудник].[Фамилия], [Сотрудник].[Отчество], [Образование].[Учебное_заведение] as [Учебное Заведение], [Образование].[Направление], [Образование].[Год_окончания] as [Год окончания] FROM [Сотрудник] INNER JOIN [Образование] ON [Образование].[Сотрудник] = [Сотрудник].Id"));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(textBox_empl_ID.Text == "")
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

                //if ((this_year - born_year - 5) < (this_year - grad_year))
                //{
                //    MessageBox.Show("Высшее образование было получено менее 5 лет назад, проверьте введенные данные", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                
                
                {
                    if (education.updateEducation(eID, institution, date, course))
                    {
                        showEducation();
                        button_clear.PerformClick();
                        MessageBox.Show("Информация об Образовании обновлена", "Образование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Информация об Образовании не была обновлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_college.Clear();
            textBox_Course.Clear();
            textBox_empl_ID.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_empl_ID.Text == "")
            {
                MessageBox.Show("Требуется выбрать сотрудника", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_empl_ID.Text);
                if (MessageBox.Show("Вы уверены что хотите удалить образование из списка?", "Удалить данные", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (education.deleteEducation(id))
                    {
                        showEducation();
                        MessageBox.Show("Образование удалено", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_empl_ID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
                textBox_college.Text = DataGridView_employee.CurrentRow.Cells[4].Value.ToString();
                textBox_Course.Text = DataGridView_employee.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker1.Value = (DateTime)DataGridView_employee.CurrentRow.Cells[6].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("В этой таблице нельзя выбрать данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_clear.PerformClick();
            }
        }

        private void button_empl_Click(object sender, EventArgs e)
        {
            showEmployee();
            DataGridView_employee.ReadOnly = true;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_employee.DataSource = education.getList(new SqlCommand("SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Образование.[Учебное_заведение], Образование.Направление, Образование.[Год_окончания] FROM Сотрудник INNER JOIN[Образование] ON[Образование].[Сотрудник] = [Сотрудник].Id WHERE CONCAT(Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Образование.[Учебное_заведение], Образование.Направление) LIKE '%"+textBox_search.Text+"%'"));
        }

        private void button_edct_Click(object sender, EventArgs e)
        {
            showEducation();
            DataGridView_employee.ReadOnly = true;
        }

        
    }
}
