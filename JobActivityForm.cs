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
    public partial class JobActivityForm : Form
    {
        JobActivityClass jobClass = new JobActivityClass();
        EmployeeClass employee = new EmployeeClass();

        public JobActivityForm()
        {
            InitializeComponent();
        }

        private void showJob()
        {
            DataGridView_employee.DataSource = jobClass.getList(new SqlCommand("SELECT Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.[Сфера_деятельности] as [Сфера Деятельности], Должность.Стаж FROM Должность INNER JOIN [Должность_сотрудника] ON [Должность_сотрудника].[Должность] = [Должность].Id INNER JOIN Сотрудник ON [Должность_сотрудника].Сотрудник = Сотрудник.Id"));
        }

        private void showEmployee()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList();
        }

        private void showJob_Edct()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand("SELECT Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Образование.Направление, Образование.[Год_окончания] as [Год окончания] FROM Сотрудник INNER JOIN Образование ON Образование.Сотрудник = Сотрудник.Id"));
        }


        private void JobActivityForm_Load(object sender, EventArgs e)
        {
            datePicker.Visible = false;
            showJob_Edct();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
        }

        private void button_empl_Click(object sender, EventArgs e)
        {
            showEmployee();
        }

        private void button_edct_Click(object sender, EventArgs e)
        {
            showJob();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_job.Text == "" || textBox_salary.Text == "" || 
                textBox_exp.Text == "" || (radioButton2.Checked == false && radioButtonYes.Checked == false))
            {
                MessageBox.Show("Заполните пустые Поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int employee_id = Convert.ToInt32(textBox_empl_ID.Text);
                string job = textBox_job.Text;
                decimal money = Convert.ToDecimal(textBox_salary.Text);
                int exp = Convert.ToInt32(textBox_exp.Text);
                string degree = textBox_grade.Text;

                
                if(!checkExper(employee_id))
                {
                    MessageBox.Show("Стаж указан неверно!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!jobClass.checkJob(employee_id))
                {
                    if (jobClass.insertJob(job, money, exp, degree))
                    {
                        jobClass.insertJobToEmpl(employee_id);
                        showJob();
                        MessageBox.Show("Данные о должности добавлены!", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Должность не была добавлена!", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Сотрудник с такой должностью уже существует", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_empl_ID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            showJob_Edct();
        }

        

        private bool checkExper(int employee_id)
        {
            DataBase dataBase = new DataBase();

            var year = 0;
            int exp = Convert.ToInt32(textBox_exp.Text);
            int this_year = DateTime.Now.Year;

            using (SqlCommand command_select = new SqlCommand($"SELECT Образование.[Год_окончания] FROM Образование Where Сотрудник={employee_id}", dataBase.getConnection))
            {
                dataBase.openConnection();
                using (SqlDataReader reader = command_select.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime dt = Convert.ToDateTime(reader[0]);
                        year = dt.Year;
                    }
                    dataBase.closeConnection();
                }
            }

            if ((this_year - year) < exp)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int employee_id = Convert.ToInt32(textBox_empl_ID.Text);
            //checkExper(employee_id);
        }
        int click = 1;
        private void radioButtonYes_Click(object sender, EventArgs e)
        {
            click++;

            if (click % 2 == 1)
            {
                radioButtonYes.Checked = false;
                radioButton2.Checked = true;
            }
            if (click % 2 == 0)
            {
                radioButtonYes.Checked = true;
                radioButton2.Checked = false;
            }
            if (radioButtonYes.Checked == false)
            {
                MessageBox.Show("Только преподаватель может иметь звание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_grade.ReadOnly = true;
            }
            if (radioButtonYes.Checked == true)
            {
                textBox_grade.ReadOnly = false;
            }
        }
    }
}

    
