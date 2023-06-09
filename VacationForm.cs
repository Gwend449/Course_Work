﻿using System;
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
    public partial class VacationForm : Form
    {
        VacationClass vacation = new VacationClass();
        DataBase dataBase = new DataBase();

        public VacationForm()
        {
            InitializeComponent();
        }

        private void VacationForm_Load(object sender, EventArgs e)
        {
            showEmployee();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column4 = DataGridView_employee.Columns[4];
            column4.Width = 160;
            DataGridView_employee.ReadOnly = true;
        }

        private void showTable()
        {
            DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select Отпуск.Id, Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Должность], Должность.Стаж, Отпуск.Дата as [Начало отпуска], Отпуск.Тип, Отпуск.Длительность as [Кол-во дней] from Отпуск INNER JOIN Должность_сотрудника as ds ON ds.Id = Отпуск.Должность_сотрудника INNER JOIN Должность ON ds.Должность = Должность.Id INNER JOIN Сотрудник ON ds.Сотрудник = Сотрудник.Id"));
            DataGridViewColumn column4 = DataGridView_employee.Columns[5];
            column4.Width = 62;
            DataGridViewColumn column0 = DataGridView_employee.Columns[7];
            column0.Width = 130;
        }

        private void showEmployee()
        {
            DataGridView_employee.DataSource = vacation.getList(new SqlCommand("select [Должность_сотрудника].Id as [ID Должн.], Сотрудник.Имя, Сотрудник.Фамилия, Сотрудник.Отчество, Должность.Сфера_деятельности as [Должность], Должность.Звание, Должность.Стаж FROM [Должность_сотрудника] INNER JOIN Сотрудник ON Сотрудник.Id = Должность_сотрудника.Сотрудник INNER JOIN Должность ON Должность_сотрудника.Должность = Должность.Id"));
        }

        private void button_edct_Click_1(object sender, EventArgs e)
        {
            showTable();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridView_employee.ReadOnly = true;
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {

            //using (SqlCommand command_select = new SqlCommand("SELECT Должность_со FROM Должность", dataBase.getConnection))
            //{
            //    using (SqlDataReader reader = command_select.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            job_id = Convert.ToInt32(reader[0].ToString());
            //        }
            //    }
            //}

            if (textBox_dur.Text == "" || textBox_empl_ID.Text == "" ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста заполните пустые поля", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    int empId = Convert.ToInt32(textBox_empl_ID.Text);
                    int duration = Convert.ToInt32(textBox_dur.Text);
                    DateTime date = dateTimePicker1.Value;
                    string type = comboBox1.Text;


                    if (vacation.checkVacationn(empId, date))
                    {
                        if (vacation.insertVacation(empId, duration, date, type))
                        {
                            showTable();
                            MessageBox.Show("Информация об отпуске успешно добавлена", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                        }   
                    }
                    else if (!vacation.checkVacationn(empId, date) || !vacation.checkVacation(empId))
                    {
                        if (vacation.insertVacation(empId, duration, date, type))
                        {
                            showTable();
                            MessageBox.Show("Информация об отпуске успешно добавлена", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button_clear.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректная дата, отпуска в одинаковое время.", "Добавить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Добавить инф. об отпуске", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_empl_ID.Clear();
            textBox_dur.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
        }

        private void DataGridView_employee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_empl_ID.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_empl_Click_1(object sender, EventArgs e)
        {
            showEmployee();
            DataGridView_employee.ReadOnly = false;
        }
    }
}
    

