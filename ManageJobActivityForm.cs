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
    public partial class ManageJobActivityForm : Form
    {
        JobActivityClass jobActivity = new JobActivityClass();
        EmployeeClass employee = new EmployeeClass();
        DataBase dataBase = new DataBase();

        public ManageJobActivityForm()
        {
            InitializeComponent();
        }

        private void ManageJobActivityForm_Load(object sender, EventArgs e)
        {
            showJob_Empl();
            datePicker.Visible = false;
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column4 = DataGridView_employee.Columns[5];
            column4.Width = 35;
        }

        private void showJob_Empl()
        {
            DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT Должность.Id as [№ Должн.], Должность.[Сфера_деятельности], Должность.Звание, Должность.Оклад, Должность.Стаж, Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество FROM Должность INNER JOIN [Должность_сотрудника] as DS ON DS.Должность = Должность.Id INNER JOIN Сотрудник ON DS.Сотрудник = Сотрудник.Id"));
        }

        private void showEmployee()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList();
        }

        private void button_empl_Click(object sender, EventArgs e)
        {
            showEmployee();
            textBox_search.ReadOnly = true;
        }

        private void showJob()
        {
            DataGridView_employee.DataSource = jobActivity.getList(new SqlCommand("SELECT Сотрудник.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.[Сфера_деятельности] as [Сфера Деятельности], Должность.Стаж FROM Должность INNER JOIN [Должность_сотрудника] ON [Должность_сотрудника].[Должность] = [Должность].Id INNER JOIN Сотрудник ON [Должность_сотрудника].Сотрудник = Сотрудник.Id"));
        }

        private void button_edct_Click(object sender, EventArgs e)
        {
            showJob();
            textBox_search.ReadOnly = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_empl_ID.Clear();
            textBox_exp.Clear();
            comboBox1.SelectedIndex = -1;
            textBox_job.Clear();
            textBox_jobID.Clear();
            textBox_salary.Clear();
            textBox_search.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_employee.DataSource = jobActivity.searchJob(textBox_search.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            showJob_Empl();
            textBox_search.ReadOnly = false;
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column4 = DataGridView_employee.Columns[5];
            column4.Width = 35;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textBox_empl_ID.Text == "" || textBox_jobID.Text == "")
            {
                MessageBox.Show("Требуется Номер Должности и Id Сотрудника", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int jobact_id = Convert.ToInt32(textBox_jobID.Text);
                string job = textBox_job.Text;
                decimal money = Convert.ToDecimal(textBox_salary.Text);
                int exp = Convert.ToInt32(textBox_exp.Text);
                string degree = comboBox1.SelectedText;
                if (checkExper())
                {
                    MessageBox.Show("Стаж указан неверно!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(jobActivity.updateJob(jobact_id, job, money, exp, degree))
                {
                    showJob();
                    button_clear.PerformClick();
                    MessageBox.Show("Данные о должности обновлены.", "Обновить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка! Данные не были обновлены.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkExper()
        {
            var year = 0;
            int employee_id = Convert.ToInt32(textBox_empl_ID.Text);
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
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_jobID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            textBox_job.Text = DataGridView_employee.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = DataGridView_employee.CurrentRow.Cells[2].Value.ToString();
            textBox_salary.Text = DataGridView_employee.CurrentRow.Cells[3].Value.ToString();
            textBox_exp.Text = DataGridView_employee.CurrentRow.Cells[4].Value.ToString();
            textBox_empl_ID.Text = DataGridView_employee.CurrentRow.Cells[5].Value.ToString();
            //datePicker.Value = (DateTime)DataGridView_employee.CurrentRow.Cells[5]
        }

        VacationClass vacation = new VacationClass();

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_empl_ID.Text == "" || textBox_jobID.Text == "")
            {
                MessageBox.Show("Заполните поля с Номером Должности и Id Сотрудника");
            }
            else
            {
                try
                {
                    int jobID = Convert.ToInt32(textBox_jobID.Text);
                    int empID = Convert.ToInt32(textBox_empl_ID.Text);
                    int vacID = getIDs(empID, jobID);
                    if (MessageBox.Show("Вы уверены что хотите убрать должность?", "Удалить должность у сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(vacation.checkVacation(empID))
                        {
                            if (vacation.deleteVacation(vacID) && jobActivity.deleteEmplJob(jobID, empID))
                            {
                                jobActivity.deleteJob(jobID);
                                showJob();
                                MessageBox.Show("Данные удалены!", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                button_clear.PerformClick();
                            }
                        }
                        if(!vacation.checkVacation(empID))
                        {
                            if (jobActivity.deleteEmplJob(jobID, empID))
                            {
                                jobActivity.deleteJob(jobID);
                                showJob();
                                MessageBox.Show("Данные удалены!", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                button_clear.PerformClick();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Удалить данные об отпуске!", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private int getIDs(int empID, int jobID)
        {
            int vacID = 0;

            using (SqlCommand command_select = new SqlCommand($"select Отпуск.Id from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id WHERE Сотрудник.Id = {empID} AND Должность.Id = {jobID}", dataBase.getConnection))
            {
                dataBase.openConnection();
                using (SqlDataReader reader = command_select.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vacID = Convert.ToInt32(reader[0]);
                    }
                    dataBase.closeConnection();
                }
            }

            return vacID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkExper();
        }

        //int click = 1;

        //private void radioButtonYes_Click(object sender, EventArgs e)
        //{
        //    click++;

        //    if (click % 2 == 1)
        //    {
        //        radioButtonYes.Checked = false;
        //        radioButton2.Checked = true;
        //    }
        //    if (click % 2 == 0)
        //    {
        //        radioButtonYes.Checked = true;
        //        radioButton2.Checked = false;
        //    }
        //    if (radioButtonYes.Checked == false)
        //    {
        //        MessageBox.Show("Только преподаватель может иметь звание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        textBox_grade.ReadOnly = true;
        //    }
        //    if (radioButtonYes.Checked == true)
        //    {
        //        textBox_grade.ReadOnly = false;
        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
