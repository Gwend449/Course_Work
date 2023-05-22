using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//DBCC CHECKIDENT('TableName', RESEED, 0)


namespace Course_Work
{
    public partial class MainForm : Form
    {
        EmployeeClass employee = new EmployeeClass();

        public MainForm()
        {
            //Thread t = new Thread(new ThreadStart(Loading));
            //t.Start();
            
            //for (int i = 0; i < 200; i++)
            //{
            //    Thread.Sleep(10);
            //}
            //t.Abort();
            InitializeComponent();
            customDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            emplCount();
        }

        void Loading()
        {
            SplashForm splashForm = new SplashForm();
            Application.Run(splashForm);
        }


        private void emplCount()
        {
            label_female.Text = "Женщин : " + employee.totalFemale();
            label_male.Text = "Мужчин : " + employee.totalMale();
            label_total.Text = "Всего сотрудников : " + employee.totalEmployees();
        }

        private void customDesign()
        {
            panel_emplSubmenu.Visible = false;
            panel_edctSubmenu.Visible = false;
            panel_postSubmenu.Visible = false;
            panel_gradeSubmenu.Visible = false;
            panel_VacSubMenu.Visible = false;
            panel_viewSubMenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_emplSubmenu.Visible == true)
                panel_emplSubmenu.Visible = false;
            if (panel_edctSubmenu.Visible == true)
                panel_edctSubmenu.Visible = false;
            if (panel_postSubmenu.Visible == true)
                panel_postSubmenu.Visible = false;
            if (panel_gradeSubmenu.Visible == true)
                panel_gradeSubmenu.Visible = false;
            if (panel_VacSubMenu.Visible == true)
                panel_VacSubMenu.Visible = false;
            if (panel_viewSubMenu.Visible == true)
                panel_viewSubMenu.Visible = false;
        }

        private void showSubmenu(Panel panel)
        {
            if(panel.Visible == false)
            {
                hideSubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_emplSubmenu);
        }
        #region employee
        private void button_Empl_addData_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Empl_editData_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageEmployeeForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_emplPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintEmployee());
            //...
            //...
            //...
            hideSubmenu();
        }

        #endregion

        private void button_education_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_edctSubmenu);
        }
        #region education
        private void button_Edct_addData_Click(object sender, EventArgs e)
        {
            openChildForm(new EducationForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_edct_editData_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageEducationForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Edct_printData_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintEducation());
            //...
            //...
            //...
            hideSubmenu();
        }
        #endregion

        private void button_post_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_postSubmenu);
        }
        #region post
        private void button_Post_addData_Click(object sender, EventArgs e)
        {
            openChildForm(new JobActivityForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Post_vacation_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageJobActivityForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Post_editData_Click(object sender, EventArgs e)
        {
            openChildForm(new VacationForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Post_print_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageVacationForm());
            //...
            //...
            //...
            hideSubmenu();
        }
        #endregion

        private void button_grade_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_gradeSubmenu);
        }
        #region grade
        private void button_Grd_addData_Click(object sender, EventArgs e)
        {
            openChildForm(new DegreeForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Grd_editData_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageDegreeForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Grd_print_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintDegree());
            //...
            //...
            //...
            hideSubmenu();
        }
        #endregion

        private void button_dash_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_VacSubMenu);
        }

        #region vacation
        private void button_Post_editData_Click_1(object sender, EventArgs e)
        {
            openChildForm(new VacationForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void button_Post_editVac_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageVacationForm());
            //...
            //...
            //...
            hideSubmenu();
        }
        #endregion



        private Form activeForm = null;
        private void openChildForm(Form child)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_main.Controls.Add(child);
            panel_main.Tag = child;
            child.BringToFront();
            child.Show();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintJobActivity());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nikita Lyapin FROM IS-31");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nikita Lyapin FROM IS-31");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_viewSubMenu);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
        }

        private void button_viewEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewEmployeeForm());
            //...
            //...
            //...
            hideSubmenu();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Application.Exit();
            }
        }

        private void button_viewEdct_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewEducationForm());
            //...
            //..
            //.
            hideSubmenu();
        }
    }
}
