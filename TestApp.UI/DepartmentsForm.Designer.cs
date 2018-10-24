namespace TestApp.UI
{
    partial class DepartmentsForm
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
            this.Dgw_departments = new System.Windows.Forms.DataGridView();
            this.Dgw_Branches = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_remove = new System.Windows.Forms.Button();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Grb_Info = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Chkb_Base = new System.Windows.Forms.CheckBox();
            this.Grb_Base = new System.Windows.Forms.GroupBox();
            this.Cmb_Deps = new System.Windows.Forms.ComboBox();
            this.Lbx_Base_Dep = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Code = new System.Windows.Forms.TextBox();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Branches)).BeginInit();
            this.Grb_Info.SuspendLayout();
            this.Grb_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgw_departments
            // 
            this.Dgw_departments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_departments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgw_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_departments.Location = new System.Drawing.Point(79, 51);
            this.Dgw_departments.Margin = new System.Windows.Forms.Padding(4);
            this.Dgw_departments.MultiSelect = false;
            this.Dgw_departments.Name = "Dgw_departments";
            this.Dgw_departments.ReadOnly = true;
            this.Dgw_departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_departments.Size = new System.Drawing.Size(955, 382);
            this.Dgw_departments.TabIndex = 0;
            this.Dgw_departments.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgw_departments_CellEnter);
            // 
            // Dgw_Branches
            // 
            this.Dgw_Branches.AllowUserToAddRows = false;
            this.Dgw_Branches.AllowUserToDeleteRows = false;
            this.Dgw_Branches.AllowUserToResizeColumns = false;
            this.Dgw_Branches.AllowUserToResizeRows = false;
            this.Dgw_Branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_Branches.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgw_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Branches.Location = new System.Drawing.Point(1053, 51);
            this.Dgw_Branches.MultiSelect = false;
            this.Dgw_Branches.Name = "Dgw_Branches";
            this.Dgw_Branches.ReadOnly = true;
            this.Dgw_Branches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Branches.Size = new System.Drawing.Size(563, 382);
            this.Dgw_Branches.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1083, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 2;
            // 
            // Btn_remove
            // 
            this.Btn_remove.Location = new System.Drawing.Point(546, 85);
            this.Btn_remove.Name = "Btn_remove";
            this.Btn_remove.Size = new System.Drawing.Size(129, 29);
            this.Btn_remove.TabIndex = 3;
            this.Btn_remove.Text = "Удалить";
            this.Btn_remove.UseVisualStyleBackColor = true;
            this.Btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // Btn_Change
            // 
            this.Btn_Change.Location = new System.Drawing.Point(546, 25);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(129, 29);
            this.Btn_Change.TabIndex = 4;
            this.Btn_Change.Text = "Изменить";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_add.Location = new System.Drawing.Point(810, 449);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(224, 42);
            this.Btn_add.TabIndex = 5;
            this.Btn_add.Text = "Добавить новый отдел";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Grb_Info
            // 
            this.Grb_Info.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grb_Info.Controls.Add(this.label6);
            this.Grb_Info.Controls.Add(this.Chkb_Base);
            this.Grb_Info.Controls.Add(this.Grb_Base);
            this.Grb_Info.Controls.Add(this.Lbx_Base_Dep);
            this.Grb_Info.Controls.Add(this.label5);
            this.Grb_Info.Controls.Add(this.label4);
            this.Grb_Info.Controls.Add(this.label3);
            this.Grb_Info.Controls.Add(this.label2);
            this.Grb_Info.Controls.Add(this.Tbx_Code);
            this.Grb_Info.Controls.Add(this.Btn_Change);
            this.Grb_Info.Controls.Add(this.Btn_remove);
            this.Grb_Info.Controls.Add(this.Tbx_Name);
            this.Grb_Info.Controls.Add(this.Tbx_ID);
            this.Grb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Grb_Info.Location = new System.Drawing.Point(79, 440);
            this.Grb_Info.Name = "Grb_Info";
            this.Grb_Info.Size = new System.Drawing.Size(703, 294);
            this.Grb_Info.TabIndex = 6;
            this.Grb_Info.TabStop = false;
            this.Grb_Info.Text = "Панель редактирования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(68, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Только точки и  заглавные латинские  буквы и цифры";
            // 
            // Chkb_Base
            // 
            this.Chkb_Base.AutoSize = true;
            this.Chkb_Base.Location = new System.Drawing.Point(96, 183);
            this.Chkb_Base.Name = "Chkb_Base";
            this.Chkb_Base.Size = new System.Drawing.Size(221, 24);
            this.Chkb_Base.TabIndex = 10;
            this.Chkb_Base.Text = "Переподчинить отдел";
            this.Chkb_Base.UseVisualStyleBackColor = true;
            this.Chkb_Base.CheckedChanged += new System.EventHandler(this.Chkb_Base_CheckedChanged);
            // 
            // Grb_Base
            // 
            this.Grb_Base.Controls.Add(this.Cmb_Deps);
            this.Grb_Base.Location = new System.Drawing.Point(96, 227);
            this.Grb_Base.Name = "Grb_Base";
            this.Grb_Base.Size = new System.Drawing.Size(459, 61);
            this.Grb_Base.TabIndex = 9;
            this.Grb_Base.TabStop = false;
            // 
            // Cmb_Deps
            // 
            this.Cmb_Deps.DisplayMember = "Name";
            this.Cmb_Deps.FormattingEnabled = true;
            this.Cmb_Deps.Location = new System.Drawing.Point(6, 25);
            this.Cmb_Deps.Name = "Cmb_Deps";
            this.Cmb_Deps.Size = new System.Drawing.Size(429, 28);
            this.Cmb_Deps.TabIndex = 7;
            this.Cmb_Deps.ValueMember = "ID";
            // 
            // Lbx_Base_Dep
            // 
            this.Lbx_Base_Dep.FormattingEnabled = true;
            this.Lbx_Base_Dep.ItemHeight = 20;
            this.Lbx_Base_Dep.Location = new System.Drawing.Point(197, 149);
            this.Lbx_Base_Dep.Name = "Lbx_Base_Dep";
            this.Lbx_Base_Dep.Size = new System.Drawing.Size(324, 24);
            this.Lbx_Base_Dep.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Главный отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // Tbx_Code
            // 
            this.Tbx_Code.Location = new System.Drawing.Point(197, 111);
            this.Tbx_Code.Name = "Tbx_Code";
            this.Tbx_Code.Size = new System.Drawing.Size(324, 26);
            this.Tbx_Code.TabIndex = 3;
            this.Tbx_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Code_KeyPress);
            this.Tbx_Code.MouseLeave += new System.EventHandler(this.Tbx_Name_MouseLeave);
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Location = new System.Drawing.Point(197, 59);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(324, 26);
            this.Tbx_Name.TabIndex = 1;
            this.Tbx_Name.TextChanged += new System.EventHandler(this.Tbx_Name_TextChanged);
            this.Tbx_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Name_KeyPress);
            this.Tbx_Name.MouseLeave += new System.EventHandler(this.Tbx_Name_MouseLeave);
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Location = new System.Drawing.Point(197, 24);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.ReadOnly = true;
            this.Tbx_ID.Size = new System.Drawing.Size(324, 26);
            this.Tbx_ID.TabIndex = 0;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 761);
            this.Controls.Add(this.Grb_Info);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgw_Branches);
            this.Controls.Add(this.Dgw_departments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DepartmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Branches)).EndInit();
            this.Grb_Info.ResumeLayout(false);
            this.Grb_Info.PerformLayout();
            this.Grb_Base.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgw_departments;
        private System.Windows.Forms.DataGridView Dgw_Branches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_remove;
        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.GroupBox Grb_Info;
        private System.Windows.Forms.TextBox Tbx_Code;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Lbx_Base_Dep;
        private System.Windows.Forms.ComboBox Cmb_Deps;
        private System.Windows.Forms.CheckBox Chkb_Base;
        private System.Windows.Forms.GroupBox Grb_Base;
        private System.Windows.Forms.Label label6;
    }
}