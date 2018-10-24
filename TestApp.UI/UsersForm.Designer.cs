namespace TestApp.UI
{
    partial class UsersForm
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
            this.Btn_Add_new_employee = new System.Windows.Forms.Button();
            this.Btn_Change_Employee = new System.Windows.Forms.Button();
            this.Lbx_Emp_details = new System.Windows.Forms.DataGridView();
            this.Tbx_MiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_departments = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbx_docSeries = new System.Windows.Forms.MaskedTextBox();
            this.Tbx_docNumber = new System.Windows.Forms.MaskedTextBox();
            this.Dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tbx_Position = new System.Windows.Forms.TextBox();
            this.Tbx_SurName = new System.Windows.Forms.TextBox();
            this.Tbx_name = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.Grb_Search = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Tbx_Search = new System.Windows.Forms.TextBox();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_ALL_employees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lbx_Emp_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Grb_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Add_new_employee
            // 
            this.Btn_Add_new_employee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_Add_new_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add_new_employee.Location = new System.Drawing.Point(715, 642);
            this.Btn_Add_new_employee.Name = "Btn_Add_new_employee";
            this.Btn_Add_new_employee.Size = new System.Drawing.Size(282, 44);
            this.Btn_Add_new_employee.TabIndex = 23;
            this.Btn_Add_new_employee.Text = "Добавить сотрудника";
            this.Btn_Add_new_employee.UseVisualStyleBackColor = false;
            this.Btn_Add_new_employee.Click += new System.EventHandler(this.Btn_Add_new_employee_Click);
            // 
            // Btn_Change_Employee
            // 
            this.Btn_Change_Employee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_Change_Employee.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Btn_Change_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Change_Employee.Location = new System.Drawing.Point(21, 567);
            this.Btn_Change_Employee.Name = "Btn_Change_Employee";
            this.Btn_Change_Employee.Size = new System.Drawing.Size(388, 28);
            this.Btn_Change_Employee.TabIndex = 24;
            this.Btn_Change_Employee.Text = "Редактировать данные";
            this.Btn_Change_Employee.UseVisualStyleBackColor = false;
            this.Btn_Change_Employee.Click += new System.EventHandler(this.Btn_Change_Employee_Click);
            // 
            // Lbx_Emp_details
            // 
            this.Lbx_Emp_details.AllowUserToAddRows = false;
            this.Lbx_Emp_details.AllowUserToDeleteRows = false;
            this.Lbx_Emp_details.AllowUserToResizeColumns = false;
            this.Lbx_Emp_details.AllowUserToResizeRows = false;
            this.Lbx_Emp_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbx_Emp_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lbx_Emp_details.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Lbx_Emp_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lbx_Emp_details.Location = new System.Drawing.Point(12, 29);
            this.Lbx_Emp_details.Name = "Lbx_Emp_details";
            this.Lbx_Emp_details.ReadOnly = true;
            this.Lbx_Emp_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lbx_Emp_details.Size = new System.Drawing.Size(982, 607);
            this.Lbx_Emp_details.TabIndex = 25;
            this.Lbx_Emp_details.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lbx_Emp_details_CellEnter);
            // 
            // Tbx_MiddleName
            // 
            this.Tbx_MiddleName.Location = new System.Drawing.Point(142, 236);
            this.Tbx_MiddleName.Name = "Tbx_MiddleName";
            this.Tbx_MiddleName.Size = new System.Drawing.Size(267, 26);
            this.Tbx_MiddleName.TabIndex = 5;
            this.Tbx_MiddleName.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(140, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Серия паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(137, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер паспорта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Отчество";
            // 
            // Cmb_departments
            // 
            this.Cmb_departments.DisplayMember = "Name";
            this.Cmb_departments.FormattingEnabled = true;
            this.Cmb_departments.Location = new System.Drawing.Point(142, 516);
            this.Cmb_departments.Name = "Cmb_departments";
            this.Cmb_departments.Size = new System.Drawing.Size(267, 28);
            this.Cmb_departments.TabIndex = 18;
            this.Cmb_departments.ValueMember = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Отдел";
            // 
            // Tbx_docSeries
            // 
            this.Tbx_docSeries.Location = new System.Drawing.Point(352, 355);
            this.Tbx_docSeries.Mask = "0000";
            this.Tbx_docSeries.Name = "Tbx_docSeries";
            this.Tbx_docSeries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tbx_docSeries.Size = new System.Drawing.Size(57, 26);
            this.Tbx_docSeries.TabIndex = 20;
            this.Tbx_docSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tbx_docSeries.ValidatingType = typeof(int);
            // 
            // Tbx_docNumber
            // 
            this.Tbx_docNumber.Location = new System.Drawing.Point(341, 407);
            this.Tbx_docNumber.Mask = "000000";
            this.Tbx_docNumber.Name = "Tbx_docNumber";
            this.Tbx_docNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tbx_docNumber.Size = new System.Drawing.Size(68, 26);
            this.Tbx_docNumber.TabIndex = 21;
            this.Tbx_docNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Dtp_Birthday
            // 
            this.Dtp_Birthday.Location = new System.Drawing.Point(144, 302);
            this.Dtp_Birthday.Name = "Dtp_Birthday";
            this.Dtp_Birthday.Size = new System.Drawing.Size(265, 26);
            this.Dtp_Birthday.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Tbx_Position);
            this.groupBox1.Controls.Add(this.Tbx_SurName);
            this.groupBox1.Controls.Add(this.Tbx_name);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.Grb_Search);
            this.groupBox1.Controls.Add(this.Btn_delete);
            this.groupBox1.Controls.Add(this.Dtp_Birthday);
            this.groupBox1.Controls.Add(this.Btn_Change_Employee);
            this.groupBox1.Controls.Add(this.Tbx_MiddleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_docNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tbx_docSeries);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cmb_departments);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(1003, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 657);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // Tbx_Position
            // 
            this.Tbx_Position.Location = new System.Drawing.Point(142, 460);
            this.Tbx_Position.Name = "Tbx_Position";
            this.Tbx_Position.Size = new System.Drawing.Size(267, 26);
            this.Tbx_Position.TabIndex = 38;
            this.Tbx_Position.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_Position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name1_KeyPress);
            this.Tbx_Position.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // Tbx_SurName
            // 
            this.Tbx_SurName.Location = new System.Drawing.Point(141, 178);
            this.Tbx_SurName.Name = "Tbx_SurName";
            this.Tbx_SurName.Size = new System.Drawing.Size(267, 26);
            this.Tbx_SurName.TabIndex = 37;
            this.Tbx_SurName.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_SurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name1_KeyPress);
            this.Tbx_SurName.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // Tbx_name
            // 
            this.Tbx_name.Location = new System.Drawing.Point(141, 116);
            this.Tbx_name.Name = "Tbx_name";
            this.Tbx_name.Size = new System.Drawing.Size(267, 26);
            this.Tbx_name.TabIndex = 36;
            this.Tbx_name.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name1_KeyPress);
            this.Tbx_name.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l3.Location = new System.Drawing.Point(190, 433);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 20);
            this.l3.TabIndex = 32;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(190, 151);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 20);
            this.l2.TabIndex = 31;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(190, 92);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 20);
            this.l1.TabIndex = 30;
            // 
            // Grb_Search
            // 
            this.Grb_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grb_Search.Controls.Add(this.Btn_Search);
            this.Grb_Search.Controls.Add(this.Tbx_Search);
            this.Grb_Search.Location = new System.Drawing.Point(33, 17);
            this.Grb_Search.Name = "Grb_Search";
            this.Grb_Search.Size = new System.Drawing.Size(375, 51);
            this.Grb_Search.TabIndex = 29;
            this.Grb_Search.TabStop = false;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(268, 12);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(94, 31);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Найти";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Tbx_Search
            // 
            this.Tbx_Search.Location = new System.Drawing.Point(16, 14);
            this.Tbx_Search.Name = "Tbx_Search";
            this.Tbx_Search.Size = new System.Drawing.Size(246, 26);
            this.Tbx_Search.TabIndex = 0;
            this.Tbx_Search.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_delete.Location = new System.Drawing.Point(21, 613);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(388, 28);
            this.Btn_delete.TabIndex = 28;
            this.Btn_delete.Text = "Удалить сотрудника";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_ALL_employees
            // 
            this.Btn_ALL_employees.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_ALL_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ALL_employees.Location = new System.Drawing.Point(427, 642);
            this.Btn_ALL_employees.Name = "Btn_ALL_employees";
            this.Btn_ALL_employees.Size = new System.Drawing.Size(282, 44);
            this.Btn_ALL_employees.TabIndex = 29;
            this.Btn_ALL_employees.Text = "Показать всех";
            this.Btn_ALL_employees.UseVisualStyleBackColor = false;
            this.Btn_ALL_employees.Click += new System.EventHandler(this.Btn_ALL_employees_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 698);
            this.Controls.Add(this.Btn_ALL_employees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbx_Emp_details);
            this.Controls.Add(this.Btn_Add_new_employee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1470, 737);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1470, 737);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lbx_Emp_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grb_Search.ResumeLayout(false);
            this.Grb_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Add_new_employee;
        private System.Windows.Forms.Button Btn_Change_Employee;
        private System.Windows.Forms.DataGridView Lbx_Emp_details;
        private System.Windows.Forms.TextBox Tbx_MiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_departments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Tbx_docSeries;
        private System.Windows.Forms.MaskedTextBox Tbx_docNumber;
        private System.Windows.Forms.DateTimePicker Dtp_Birthday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.GroupBox Grb_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tbx_Search;
        private System.Windows.Forms.Button Btn_ALL_employees;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox Tbx_Position;
        private System.Windows.Forms.TextBox Tbx_SurName;
        private System.Windows.Forms.TextBox Tbx_name;
    }
}