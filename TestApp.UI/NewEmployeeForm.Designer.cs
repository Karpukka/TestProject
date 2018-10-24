namespace TestApp.UI
{
    partial class NewEmployeeForm
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
            this.Tbx_docNumber = new System.Windows.Forms.MaskedTextBox();
            this.Tbx_docSeries = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cmb_departments = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Position = new System.Windows.Forms.TextBox();
            this.Tbx_MiddleName = new System.Windows.Forms.TextBox();
            this.Tbx_name = new System.Windows.Forms.TextBox();
            this.Tbx_SurName = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbx_docNumber
            // 
            this.Tbx_docNumber.Location = new System.Drawing.Point(194, 338);
            this.Tbx_docNumber.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_docNumber.Mask = "000000";
            this.Tbx_docNumber.Name = "Tbx_docNumber";
            this.Tbx_docNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tbx_docNumber.Size = new System.Drawing.Size(111, 26);
            this.Tbx_docNumber.TabIndex = 41;
            this.Tbx_docNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tbx_docSeries
            // 
            this.Tbx_docSeries.Location = new System.Drawing.Point(213, 281);
            this.Tbx_docSeries.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_docSeries.Mask = "0000";
            this.Tbx_docSeries.Name = "Tbx_docSeries";
            this.Tbx_docSeries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tbx_docSeries.Size = new System.Drawing.Size(92, 26);
            this.Tbx_docSeries.TabIndex = 40;
            this.Tbx_docSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tbx_docSeries.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(91, 466);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Отдел";
            // 
            // Cmb_departments
            // 
            this.Cmb_departments.DisplayMember = "Name";
            this.Cmb_departments.FormattingEnabled = true;
            this.Cmb_departments.Location = new System.Drawing.Point(190, 458);
            this.Cmb_departments.Margin = new System.Windows.Forms.Padding(5);
            this.Cmb_departments.Name = "Cmb_departments";
            this.Cmb_departments.Size = new System.Drawing.Size(297, 28);
            this.Cmb_departments.TabIndex = 38;
            this.Cmb_departments.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(67, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Серия паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Имя";
            // 
            // Tbx_Position
            // 
            this.Tbx_Position.Location = new System.Drawing.Point(191, 397);
            this.Tbx_Position.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_Position.Name = "Tbx_Position";
            this.Tbx_Position.Size = new System.Drawing.Size(297, 26);
            this.Tbx_Position.TabIndex = 30;
            this.Tbx_Position.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_Position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name_KeyPress);
            this.Tbx_Position.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // Tbx_MiddleName
            // 
            this.Tbx_MiddleName.Location = new System.Drawing.Point(195, 155);
            this.Tbx_MiddleName.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_MiddleName.Name = "Tbx_MiddleName";
            this.Tbx_MiddleName.Size = new System.Drawing.Size(293, 26);
            this.Tbx_MiddleName.TabIndex = 29;
            this.Tbx_MiddleName.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            // 
            // Tbx_name
            // 
            this.Tbx_name.Location = new System.Drawing.Point(194, 38);
            this.Tbx_name.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_name.Name = "Tbx_name";
            this.Tbx_name.Size = new System.Drawing.Size(293, 26);
            this.Tbx_name.TabIndex = 28;
            this.Tbx_name.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name_KeyPress);
            this.Tbx_name.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // Tbx_SurName
            // 
            this.Tbx_SurName.Location = new System.Drawing.Point(194, 98);
            this.Tbx_SurName.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_SurName.Name = "Tbx_SurName";
            this.Tbx_SurName.Size = new System.Drawing.Size(293, 26);
            this.Tbx_SurName.TabIndex = 27;
            this.Tbx_SurName.TextChanged += new System.EventHandler(this.Tbx_name_TextChanged);
            this.Tbx_SurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_name_KeyPress);
            this.Tbx_SurName.MouseLeave += new System.EventHandler(this.Tbx_name_MouseLeave);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Ok.Location = new System.Drawing.Point(34, 534);
            this.Btn_Ok.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(161, 51);
            this.Btn_Ok.TabIndex = 43;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Cancel.Location = new System.Drawing.Point(333, 534);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(158, 51);
            this.Btn_Cancel.TabIndex = 44;
            this.Btn_Cancel.Text = "CANCEL";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Dtp_Birthday
            // 
            this.Dtp_Birthday.Location = new System.Drawing.Point(194, 232);
            this.Dtp_Birthday.Name = "Dtp_Birthday";
            this.Dtp_Birthday.Size = new System.Drawing.Size(293, 26);
            this.Dtp_Birthday.TabIndex = 45;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(191, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 20);
            this.l1.TabIndex = 46;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(195, 73);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 20);
            this.l2.TabIndex = 47;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(195, 372);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 20);
            this.l3.TabIndex = 48;
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 612);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Dtp_Birthday);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Tbx_docNumber);
            this.Controls.Add(this.Tbx_docSeries);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cmb_departments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbx_Position);
            this.Controls.Add(this.Tbx_MiddleName);
            this.Controls.Add(this.Tbx_name);
            this.Controls.Add(this.Tbx_SurName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 651);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(554, 651);
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Tbx_docNumber;
        private System.Windows.Forms.MaskedTextBox Tbx_docSeries;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cmb_departments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_Position;
        private System.Windows.Forms.TextBox Tbx_MiddleName;
        private System.Windows.Forms.TextBox Tbx_name;
        private System.Windows.Forms.TextBox Tbx_SurName;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DateTimePicker Dtp_Birthday;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
    }
}