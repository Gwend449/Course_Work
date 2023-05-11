using DGVPrinterHelper;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class PrintEducation : Form
    {
        EducationClass education = new EducationClass();
        DGVPrinter helper = new DGVPrinter();

        public PrintEducation()
        {
            InitializeComponent();
        }

        private void PrintEducation_Load(object sender, EventArgs e)
        {
            showData(new SqlCommand("SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Сотрудник.Пол, Образование.[Учебное_заведение], Образование.Направление, Образование.[Год_окончания] FROM Сотрудник INNER JOIN[Образование] ON[Образование].[Сотрудник] = [Сотрудник].Id"));
            DataGridViewColumn column0 = DataGridView_employee.Columns[0];
            column0.Width = 35;
            DataGridViewColumn column5 = DataGridView_employee.Columns[5];
        }

        public void showData(SqlCommand command)
        {
            DataGridView_employee.ReadOnly = true;
            DataGridView_employee.DataSource = education.getList(command);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            string selectQuery;

            if (radioButton1.Checked)
            {
                selectQuery = "SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Сотрудник.Пол, Образование.[Учебное_заведение], Образование.Направление, Образование.[Год_окончания] FROM Сотрудник INNER JOIN[Образование] ON[Образование].[Сотрудник] = [Сотрудник].Id";
            }
            else if (radioButton_FeMale.Checked)
            {
                selectQuery = "SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Сотрудник.Пол, Образование.[Учебное_заведение], Образование.Направление, Образование.[Год_окончания] FROM Сотрудник INNER JOIN[Образование] ON[Образование].[Сотрудник] = [Сотрудник].Id WHERE Сотрудник.[Пол] = 'Женщина'";
            }
            else
            {
                selectQuery = "SELECT Образование.Id, Сотрудник.Имя, Сотрудник.Отчество, Сотрудник.Пол, Образование.[Учебное_заведение], Образование.Направление, Образование.[Год_окончания] FROM Сотрудник INNER JOIN[Образование] ON[Образование].[Сотрудник] = [Сотрудник].Id Where Сотрудник.[Пол] = 'Мужчина'";
            }
            showData(new SqlCommand(selectQuery));
            printData();
        }

        private void printData()
        {
            helper.Title = "Информация об Образовании сотрудников ННГАСУ";
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
