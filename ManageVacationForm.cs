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
    public partial class ManageVacationForm : Form
    {
        VacationClass vacation = new VacationClass();

        public ManageVacationForm()
        {
            InitializeComponent();
        }

        private void ManageVacationForm_Load(object sender, EventArgs e)
        {
            showTable();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column3 = DataGridView_employee.Columns[4];
            column3.Width = 180;
            DataGridViewColumn column4 = DataGridView_employee.Columns[5];
            column4.Width = 80;
            DataGridViewColumn column6 = DataGridView_employee.Columns[7];
            column6.Width = 145;
        }

        private void showTable()
        {
            DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Должность], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Кол-во дней] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_dur.Clear();
            textBox_vacID.Clear();
            dateTimePicker2.Value = DateTime.Now;
            comboBox2.SelectedIndex = -1;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(textBox_vacID.Text == "")
            {
                MessageBox.Show("Пожалуйста выберите отпуск сотрудника.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int vacID = Convert.ToInt32(textBox_vacID.Text);
                int dur = Convert.ToInt32(textBox_dur.Text);
                string type = comboBox2.Text;
                DateTime date = dateTimePicker2.Value;

                try
                {
                    if(vacation.updateVacation(vacID, dur, date, type))
                    {
                        showTable();
                        MessageBox.Show("Информация об отпуске успешно изменена!", "Изменить отпуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Изменить отпуск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_vacID.Text == "")
            {
                MessageBox.Show("Пожалуйста выберите отпуск сотрудника.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int vacID = Convert.ToInt32(textBox_vacID.Text);

                try
                {
                    if (MessageBox.Show("Вы уверены что хотите удалить данные об отпуске сотрудника?", "Удалить отпуск", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        if(vacation.deleteVacation(vacID))
                        {
                            showTable();
                            MessageBox.Show("Данные об отпуске успешно удалены.", "Удалить отпуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Изменить отпуск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_vacID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            textBox_dur.Text = DataGridView_employee.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker2.Value = (DateTime)DataGridView_employee.CurrentRow.Cells[5].Value;
            comboBox2.Text = DataGridView_employee.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
