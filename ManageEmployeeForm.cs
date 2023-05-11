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
    public partial class ManageEmployeeForm : Form
    {
        EmployeeClass employee = new EmployeeClass();

        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_employee.DataSource = employee.getEmployeeList();
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            showTable();
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            //DataGridViewColumn column5 = DataGridView_employee.Columns[5];
            //column5.Width = 90;
        }

        private void DataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_employee.CurrentRow.Cells[0].Value.ToString();
            textBox_LName.Text = DataGridView_employee.CurrentRow.Cells[1].Value.ToString();
            textBox_Name.Text = DataGridView_employee.CurrentRow.Cells[2].Value.ToString();
            textBox_DName.Text = DataGridView_employee.CurrentRow.Cells[3].Value.ToString();
            if (DataGridView_employee.CurrentRow.Cells[4].Value.ToString() == "Мужчина")
                radioButton_Male.Checked = true;
            dateTimePicker1.Value = (DateTime)DataGridView_employee.CurrentRow.Cells[5].Value;
            textBox_Address.Text = DataGridView_employee.CurrentRow.Cells[6].Value.ToString();

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Address.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox_DName.Clear();
            textBox_LName.Clear();
            textBox_Name.Clear();
            textBox_id.Clear();
            radioButton_Male.Checked = true;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_employee.DataSource = employee.searchEmployee(textBox_search.Text);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
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
                    if (employee.updateEmployee(id,name, lastname, dname, age, gender, address))
                    {
                        showTable();
                        MessageBox.Show("Данные сотрудника изменены", "Изменить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле", "Изменить данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if (textBox_Address.Text == "" || 
                textBox_DName.Text == "" || textBox_LName.Text == "" || textBox_Name.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text == "")
            {
                MessageBox.Show("Пустое поле. Для удаление нужно указать ID сотрудника.", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Вы уверены что хотите удалить сотрудника из списка?", "Удалить данные", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(employee.deleteEmployee(id))
                    {
                        showTable();
                        MessageBox.Show("Сотрудник удален", "Удалить данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }
    }
}
