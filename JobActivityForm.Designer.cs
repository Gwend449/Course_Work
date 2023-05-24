namespace Course_Work
{
    partial class JobActivityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edct = new System.Windows.Forms.Button();
            this.button_empl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_job = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_empl_ID = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.textBox_exp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(390, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Должность";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button_edct);
            this.panel1.Controls.Add(this.button_empl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 64);
            this.panel1.TabIndex = 48;
            // 
            // button_edct
            // 
            this.button_edct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_edct.BackColor = System.Drawing.Color.White;
            this.button_edct.FlatAppearance.BorderSize = 0;
            this.button_edct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.button_edct.Location = new System.Drawing.Point(711, 12);
            this.button_edct.Name = "button_edct";
            this.button_edct.Size = new System.Drawing.Size(211, 42);
            this.button_edct.TabIndex = 38;
            this.button_edct.Text = "Показать должность сотрудников";
            this.button_edct.UseVisualStyleBackColor = false;
            this.button_edct.Click += new System.EventHandler(this.button_edct_Click);
            // 
            // button_empl
            // 
            this.button_empl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_empl.BackColor = System.Drawing.Color.White;
            this.button_empl.FlatAppearance.BorderSize = 0;
            this.button_empl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_empl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_empl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.button_empl.Location = new System.Drawing.Point(12, 12);
            this.button_empl.Name = "button_empl";
            this.button_empl.Size = new System.Drawing.Size(211, 42);
            this.button_empl.TabIndex = 37;
            this.button_empl.Text = "Показать сотрудников для добавления должности";
            this.button_empl.UseVisualStyleBackColor = false;
            this.button_empl.Click += new System.EventHandler(this.button_empl_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(12, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 10);
            this.panel2.TabIndex = 49;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_clear.BackColor = System.Drawing.Color.MediumBlue;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(798, 491);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(109, 42);
            this.button_clear.TabIndex = 47;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(798, 546);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 42);
            this.button_add.TabIndex = 46;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(20, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cтаж :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Сфера деятельности :";
            // 
            // textBox_job
            // 
            this.textBox_job.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_job.Location = new System.Drawing.Point(218, 456);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.Size = new System.Drawing.Size(456, 27);
            this.textBox_job.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(426, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Оклад :";
            // 
            // DataGridView_employee
            // 
            this.DataGridView_employee.AllowUserToAddRows = false;
            this.DataGridView_employee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_employee.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_employee.ColumnHeadersHeight = 48;
            this.DataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.Location = new System.Drawing.Point(12, 74);
            this.DataGridView_employee.Name = "DataGridView_employee";
            this.DataGridView_employee.RowHeadersVisible = false;
            this.DataGridView_employee.RowTemplate.Height = 60;
            this.DataGridView_employee.RowTemplate.ReadOnly = true;
            this.DataGridView_employee.Size = new System.Drawing.Size(910, 298);
            this.DataGridView_employee.TabIndex = 40;
            this.DataGridView_employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_employee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_employee.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_employee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_employee.ThemeStyle.HeaderStyle.Height = 48;
            this.DataGridView_employee.ThemeStyle.ReadOnly = false;
            this.DataGridView_employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_employee.ThemeStyle.RowsStyle.Height = 60;
            this.DataGridView_employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_employee_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Сотрудник (ID) :";
            // 
            // textBox_empl_ID
            // 
            this.textBox_empl_ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_empl_ID.Location = new System.Drawing.Point(170, 413);
            this.textBox_empl_ID.Name = "textBox_empl_ID";
            this.textBox_empl_ID.Size = new System.Drawing.Size(165, 27);
            this.textBox_empl_ID.TabIndex = 38;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_salary.Location = new System.Drawing.Point(509, 500);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(165, 27);
            this.textBox_salary.TabIndex = 53;
            // 
            // textBox_exp
            // 
            this.textBox_exp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_exp.Location = new System.Drawing.Point(86, 545);
            this.textBox_exp.Name = "textBox_exp";
            this.textBox_exp.Size = new System.Drawing.Size(165, 27);
            this.textBox_exp.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(20, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Звание :";
            // 
            // datePicker
            // 
            this.datePicker.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.datePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.datePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.datePicker.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.datePicker.Location = new System.Drawing.Point(870, 408);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(41, 27);
            this.datePicker.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Лаборант",
            "Старший Лаборант",
            "Ассистент",
            "Преподаватель",
            "Старший Преподаватель",
            "Доцент",
            "Профессор",
            "Зав. Кафедрой",
            "Декан",
            "Проректор",
            "Ректор"});
            this.comboBox1.Location = new System.Drawing.Point(105, 500);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 29);
            this.comboBox1.TabIndex = 57;
            // 
            // JobActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_exp);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_job);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_empl_ID);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "JobActivityForm";
            this.Text = "JobActivityForm";
            this.Load += new System.EventHandler(this.JobActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edct;
        private System.Windows.Forms.Button button_empl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_job;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_empl_ID;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.TextBox textBox_exp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}