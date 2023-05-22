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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int starttoint=0;
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starttoint += 1;
            guna2ProgressIndicator1.Start();
            if (starttoint > 35)
            {
                MainForm mainForm = new MainForm();
                guna2ProgressIndicator1.Stop();
                timer1.Stop();
                this.Hide();
                mainForm.Show();
            }
        }

        
    }
}
