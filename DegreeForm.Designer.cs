namespace Course_Work
{
    partial class DegreeForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_empl = new System.Windows.Forms.Button();
            this.radioButton_FeMale = new System.Windows.Forms.RadioButton();
            this.radioButton_Degree = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridView_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_empId = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(12, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 10);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button_edct);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_empl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 64);
            this.panel1.TabIndex = 25;
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
            this.button_edct.TabIndex = 40;
            this.button_edct.Text = "Показать cтепени сотрудников";
            this.button_edct.UseVisualStyleBackColor = false;
            this.button_edct.Click += new System.EventHandler(this.button_edct_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(351, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ученая Степень";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.button_empl.TabIndex = 39;
            this.button_empl.Text = "Показать сотрудников для добавления степени";
            this.button_empl.UseVisualStyleBackColor = false;
            this.button_empl.Click += new System.EventHandler(this.button_empl_Click);
            // 
            // radioButton_FeMale
            // 
            this.radioButton_FeMale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton_FeMale.AutoSize = true;
            this.radioButton_FeMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FeMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.radioButton_FeMale.Location = new System.Drawing.Point(295, 525);
            this.radioButton_FeMale.Name = "radioButton_FeMale";
            this.radioButton_FeMale.Size = new System.Drawing.Size(131, 23);
            this.radioButton_FeMale.TabIndex = 24;
            this.radioButton_FeMale.Text = "Доктор Наук";
            this.radioButton_FeMale.UseVisualStyleBackColor = true;
            // 
            // radioButton_Degree
            // 
            this.radioButton_Degree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButton_Degree.AutoSize = true;
            this.radioButton_Degree.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.radioButton_Degree.Location = new System.Drawing.Point(127, 525);
            this.radioButton_Degree.Name = "radioButton_Degree";
            this.radioButton_Degree.Size = new System.Drawing.Size(151, 23);
            this.radioButton_Degree.TabIndex = 23;
            this.radioButton_Degree.Text = "Кандидат Наук";
            this.radioButton_Degree.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(30, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Степень :";
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
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employee.Location = new System.Drawing.Point(12, 70);
            this.DataGridView_employee.Name = "DataGridView_employee";
            this.DataGridView_employee.RowHeadersVisible = false;
            this.DataGridView_employee.RowTemplate.Height = 70;
            this.DataGridView_employee.RowTemplate.ReadOnly = true;
            this.DataGridView_employee.Size = new System.Drawing.Size(910, 349);
            this.DataGridView_employee.TabIndex = 21;
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
            this.DataGridView_employee.ThemeStyle.RowsStyle.Height = 70;
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
            this.label1.Location = new System.Drawing.Point(30, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Сотрудник (Id) :";
            // 
            // textBox_empId
            // 
            this.textBox_empId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_empId.Location = new System.Drawing.Point(173, 455);
            this.textBox_empId.Name = "textBox_empId";
            this.textBox_empId.ReadOnly = true;
            this.textBox_empId.Size = new System.Drawing.Size(123, 27);
            this.textBox_empId.TabIndex = 19;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_clear.BackColor = System.Drawing.Color.MediumBlue;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(798, 490);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(109, 42);
            this.button_clear.TabIndex = 49;
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
            this.button_add.Location = new System.Drawing.Point(798, 545);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 42);
            this.button_add.TabIndex = 48;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_FeMale);
            this.Controls.Add(this.radioButton_Degree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridView_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_empId);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DegreeForm";
            this.Text = "DegreeForm";
            this.Load += new System.EventHandler(this.DegreeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_FeMale;
        private System.Windows.Forms.RadioButton radioButton_Degree;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_empId;
        private System.Windows.Forms.Button button_edct;
        private System.Windows.Forms.Button button_empl;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
    }
}