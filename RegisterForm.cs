using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class RegisterForm : Form
    {
        EmployeeClass employee = new EmployeeClass();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string lastname = textBox_LName.Text;
            string dname = textBox_DName.Text;
            DateTime age = dateTimePicker1.Value;
            string address = textBox_Address.Text;
            string gender = radioButton_Male.Checked ? "Мужчина" : "Женщина";

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 23 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Возраст сотрудника должен быть между 20 и 100 годами", "Неправильный возраст", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (employee.insertEmployee(name, lastname, dname, age, gender, address))
                    {
                        showTable();
                        MessageBox.Show("Сотрудник добавлен", "Добавить сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле", "Добавить сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Address.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox_DName.Clear();
            textBox_LName.Clear();
            textBox_Name.Clear();
        }

        bool verify()
        {
            if(textBox_Address.Text == "" || textBox_DName.Text == "" 
                || textBox_LName.Text == "" || textBox_Name.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void showTable()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            //DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            //column5.Width = 90;
        }
    }
}
