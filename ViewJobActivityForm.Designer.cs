namespace Course_Work
{
    partial class ViewJobActivityForm
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
            this.comboBox_title = new System.Windows.Forms.ComboBox();
            this.comboBox_job = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_show = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_exp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
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
            this.label7.Location = new System.Drawing.Point(301, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Просмотр (должность)";
            // 
            // comboBox_title
            // 
            this.comboBox_title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_title.FormattingEnabled = true;
            this.comboBox_title.Items.AddRange(new object[] {
            "Все",
            "Мужчина",
            "Женщина"});
            this.comboBox_title.Location = new System.Drawing.Point(380, 568);
            this.comboBox_title.Name = "comboBox_title";
            this.comboBox_title.Size = new System.Drawing.Size(181, 29);
            this.comboBox_title.TabIndex = 74;
            // 
            // comboBox_job
            // 
            this.comboBox_job.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_job.FormattingEnabled = true;
            this.comboBox_job.Location = new System.Drawing.Point(13, 568);
            this.comboBox_job.Name = "comboBox_job";
            this.comboBox_job.Size = new System.Drawing.Size(340, 29);
            this.comboBox_job.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(376, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Звание";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "Сфера деятельности";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Сортировать по :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 67);
            this.panel1.TabIndex = 65;
            // 
            // button_show
            // 
            this.button_show.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_show.BackColor = System.Drawing.Color.MediumBlue;
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show.ForeColor = System.Drawing.Color.White;
            this.button_show.Location = new System.Drawing.Point(799, 512);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(121, 37);
            this.button_show.TabIndex = 69;
            this.button_show.Text = "Показать";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_print
            // 
            this.button_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_print.BackColor = System.Drawing.Color.MediumBlue;
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(799, 561);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(121, 37);
            this.button_print.TabIndex = 68;
            this.button_print.Text = "Печать";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(13, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 10);
            this.panel2.TabIndex = 67;
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
            this.DataGridView_employee.Location = new System.Drawing.Point(13, 74);
            this.DataGridView_employee.Name = "DataGridView_employee";
            this.DataGridView_employee.RowHeadersVisible = false;
            this.DataGridView_employee.RowTemplate.Height = 60;
            this.DataGridView_employee.RowTemplate.ReadOnly = true;
            this.DataGridView_employee.Size = new System.Drawing.Size(907, 400);
            this.DataGridView_employee.TabIndex = 66;
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
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(602, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Стаж";
            // 
            // textBox_exp
            // 
            this.textBox_exp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_exp.Location = new System.Drawing.Point(606, 568);
            this.textBox_exp.Name = "textBox_exp";
            this.textBox_exp.Size = new System.Drawing.Size(88, 27);
            this.textBox_exp.TabIndex = 76;
            this.textBox_exp.TextChanged += new System.EventHandler(this.textBox_exp_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(367, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 78;
            this.label9.Text = "(Поиск по Ф.И.О)";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_search.Location = new System.Drawing.Point(518, 504);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(176, 27);
            this.textBox_search.TabIndex = 77;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // ViewJobActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_exp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_title);
            this.Controls.Add(this.comboBox_job);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_employee);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewJobActivityForm";
            this.Text = "ViewJobActivityForm";
            this.Load += new System.EventHandler(this.ViewJobActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_title;
        private System.Windows.Forms.ComboBox comboBox_job;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_employee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_exp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_search;
    }
}