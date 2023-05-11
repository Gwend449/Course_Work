﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Course_Work
{
    public partial class PrintEmployee : Form
    {
        EmployeeClass employee = new EmployeeClass();
        DGVPrinter helper = new DGVPrinter();

        public PrintEmployee()
        {
            InitializeComponent();
        }

        private void PrintEmployee_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("SELECT * FROM [Сотрудник]"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            column5.Width = 90;
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = employee.getEmployeeList(command);
        }

        private void button_print_Click(object sender, EventArgs e)
        { 
            string selectQuery;

            if (radioButton1.Checked)
            {
                selectQuery = "SELECT * FROM [Сотрудник]";
            }
            else if (radioButton_FeMale.Checked)
            {
                selectQuery = "SELECT * FROM[Сотрудник] Where[Пол] = 'Женщина'";
            }
            else
            {
                selectQuery = "SELECT * FROM[Сотрудник] Where[Пол] = 'Мужчина'";
            }
            showData(new SqlCommand(selectQuery));
            printData();
        }

        private void printData()
        {
            helper.Title = "Список сотрудников ННГАСУ";
            helper.SubTitle = string.Format("Date: (0)", DateTime.Now.Date);
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