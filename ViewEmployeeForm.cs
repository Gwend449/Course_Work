﻿using DGVPrinterHelper;
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
    public partial class ViewEmployeeForm : Form
    {
        EmployeeClass employee = new EmployeeClass();

        public ViewEmployeeForm()
        {
            InitializeComponent();
        }

        private void ViewEmployeeForm_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("SELECT * FROM [Сотрудник]"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 90;
            comboBox_adr.DataSource = employee.getEmployeeList(new SqlCommand("SELECT DISTINCT [Адрес] FROM Сотрудник"));
            comboBox_adr.DisplayMember = "Адрес";
            comboBox_adr.ValueMember = "Адрес";
            
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = employee.getEmployeeList(command);
        }


        private void button_show_Click(object sender, EventArgs e)
        {
            string city = comboBox_adr.Text;
            string sex = comboBox_sex.Text;
            if(city != "" && sex == "")
            {
                DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand($"SELECT * FROM Сотрудник WHERE Адрес = '{city}'"));
            }
            else if(city == "" && sex == "Все")
            {
                DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand($"SELECT * FROM Сотрудник"));
            }
            else if(city != "" && sex == "Все")
            {
                DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand($"SELECT * FROM Сотрудник WHERE Адрес = '{city}'"));
            }
            else if (city != "" && sex != "")
            {
                DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand($"SELECT * FROM Сотрудник WHERE Адрес = '{city}' AND Пол = '{sex}'"));
            }
            else if (city == "" && sex != "")
            {
                DataGridView_employee.DataSource = employee.getEmployeeList(new SqlCommand($"SELECT * FROM Сотрудник WHERE Пол = '{sex}'"));
            }    
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printData();
        }

        private void printData()
        {
            DGVPrinter helper = new DGVPrinter();

            helper.Title = "Информация о Сотрудниках ННГАСУ";
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
