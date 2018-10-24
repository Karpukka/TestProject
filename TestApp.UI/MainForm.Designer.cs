namespace TestApp.UI
{
    partial class MainForm
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
            this.Grb_departments = new System.Windows.Forms.GroupBox();
            this.Btn_Change_Employees = new System.Windows.Forms.Button();
            this.Btn_Change_Departments = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgw_Departments = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеОтделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grb_departments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Departments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grb_departments
            // 
            this.Grb_departments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grb_departments.Controls.Add(this.pictureBox1);
            this.Grb_departments.Controls.Add(this.Btn_Change_Employees);
            this.Grb_departments.Controls.Add(this.Btn_Change_Departments);
            this.Grb_departments.Controls.Add(this.label7);
            this.Grb_departments.Controls.Add(this.label6);
            this.Grb_departments.Controls.Add(this.label1);
            this.Grb_departments.Controls.Add(this.Dgw_Departments);
            this.Grb_departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Grb_departments.Location = new System.Drawing.Point(34, 136);
            this.Grb_departments.Margin = new System.Windows.Forms.Padding(4);
            this.Grb_departments.Name = "Grb_departments";
            this.Grb_departments.Padding = new System.Windows.Forms.Padding(4);
            this.Grb_departments.Size = new System.Drawing.Size(1056, 441);
            this.Grb_departments.TabIndex = 0;
            this.Grb_departments.TabStop = false;
            this.Grb_departments.Text = "Рога и копыта";
            // 
            // Btn_Change_Employees
            // 
            this.Btn_Change_Employees.Location = new System.Drawing.Point(7, 360);
            this.Btn_Change_Employees.Name = "Btn_Change_Employees";
            this.Btn_Change_Employees.Size = new System.Drawing.Size(232, 74);
            this.Btn_Change_Employees.TabIndex = 9;
            this.Btn_Change_Employees.Text = "Персонал";
            this.Btn_Change_Employees.UseVisualStyleBackColor = true;
            this.Btn_Change_Employees.Click += new System.EventHandler(this.Btn_Change_Employees_Click);
            // 
            // Btn_Change_Departments
            // 
            this.Btn_Change_Departments.Location = new System.Drawing.Point(262, 361);
            this.Btn_Change_Departments.Name = "Btn_Change_Departments";
            this.Btn_Change_Departments.Size = new System.Drawing.Size(232, 73);
            this.Btn_Change_Departments.TabIndex = 8;
            this.Btn_Change_Departments.Text = "Отделы";
            this.Btn_Change_Departments.UseVisualStyleBackColor = true;
            this.Btn_Change_Departments.Click += new System.EventHandler(this.Btn_Change_Departments_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отделы";
            // 
            // Dgw_Departments
            // 
            this.Dgw_Departments.AllowUserToAddRows = false;
            this.Dgw_Departments.AllowUserToDeleteRows = false;
            this.Dgw_Departments.AllowUserToResizeColumns = false;
            this.Dgw_Departments.AllowUserToResizeRows = false;
            this.Dgw_Departments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgw_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Departments.Location = new System.Drawing.Point(7, 76);
            this.Dgw_Departments.Name = "Dgw_Departments";
            this.Dgw_Departments.ReadOnly = true;
            this.Dgw_Departments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgw_Departments.Size = new System.Drawing.Size(487, 271);
            this.Dgw_Departments.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(200, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 55);
            this.label5.TabIndex = 3;
            this.label5.Text = "Фирма \"Рога и Копыта\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.персоналToolStripMenuItem,
            this.отделыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem});
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.персоналToolStripMenuItem.Text = "Персонал";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Окно работы с персоналом";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.Btn_Change_Employees_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеОтделовToolStripMenuItem});
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.отделыToolStripMenuItem.Text = "Отделы";
            // 
            // редактированиеОтделовToolStripMenuItem
            // 
            this.редактированиеОтделовToolStripMenuItem.Name = "редактированиеОтделовToolStripMenuItem";
            this.редактированиеОтделовToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редактированиеОтделовToolStripMenuItem.Text = "Редактирование отделов";
            this.редактированиеОтделовToolStripMenuItem.Click += new System.EventHandler(this.Btn_Change_Departments_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TestApp.UI.Properties.Resources.r;
            this.pictureBox1.Location = new System.Drawing.Point(528, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 408);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 617);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grb_departments);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Grb_departments.ResumeLayout(false);
            this.Grb_departments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Departments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grb_departments;
        private System.Windows.Forms.DataGridView Dgw_Departments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Change_Employees;
        private System.Windows.Forms.Button Btn_Change_Departments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеОтделовToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

