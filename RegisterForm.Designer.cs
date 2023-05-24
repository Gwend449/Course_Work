namespace Course_Work
{
    partial class RegisterForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_FeMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Name.Location = new System.Drawing.Point(117, 389);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(165, 27);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.DataGridView_employee.ColumnHeadersHeight = 34;
            this.DataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.Location = new System.Drawing.Point(12, 67);
            this.DataGridView_employee.Name = "DataGridView_employee";
            this.DataGridView_employee.RowHeadersVisible = false;
            this.DataGridView_employee.RowTemplate.Height = 70;
            this.DataGridView_employee.RowTemplate.ReadOnly = true;
            this.DataGridView_employee.Size = new System.Drawing.Size(910, 293);
            this.DataGridView_employee.TabIndex = 3;
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
            this.DataGridView_employee.ThemeStyle.HeaderStyle.Height = 34;
            this.DataGridView_employee.ThemeStyle.ReadOnly = false;
            this.DataGridView_employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_employee.ThemeStyle.RowsStyle.Height = 70;
            this.DataGridView_employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(327, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия :";
            // 
            // textBox_LName
            // 
            this.textBox_LName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_LName.Location = new System.Drawing.Point(429, 389);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(165, 27);
            this.textBox_LName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(635, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество :";
            // 
            // textBox_DName
            // 
            this.textBox_DName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_DName.Location = new System.Drawing.Point(737, 389);
            this.textBox_DName.Name = "textBox_DName";
            this.textBox_DName.Size = new System.Drawing.Size(165, 27);
            this.textBox_DName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(27, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Возраст :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(415, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол :";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Checked = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.radioButton_Male.Location = new System.Drawing.Point(492, 457);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(102, 23);
            this.radioButton_Male.TabIndex = 11;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Мужчина";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_FeMale
            // 
            this.radioButton_FeMale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton_FeMale.AutoSize = true;
            this.radioButton_FeMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FeMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.radioButton_FeMale.Location = new System.Drawing.Point(621, 457);
            this.radioButton_FeMale.Name = "radioButton_FeMale";
            this.radioButton_FeMale.Size = new System.Drawing.Size(108, 23);
            this.radioButton_FeMale.TabIndex = 12;
            this.radioButton_FeMale.Text = "Женщина";
            this.radioButton_FeMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(33, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Адрес :";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_Address.Location = new System.Drawing.Point(122, 515);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(607, 64);
            this.textBox_Address.TabIndex = 13;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(793, 553);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 42);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_clear.BackColor = System.Drawing.Color.MediumBlue;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(793, 498);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(109, 42);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 64);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(349, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Новый сотрудник";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(12, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 10);
            this.panel2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.radioButton_FeMale);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_LName);
            this.Controls.Add(this.DataGridView_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_FeMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}