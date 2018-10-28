namespace TestApp.UI
{
    partial class NewDepartmentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Code = new System.Windows.Forms.TextBox();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.ChBx_Base = new System.Windows.Forms.CheckBox();
            this.Grb_Base = new System.Windows.Forms.GroupBox();
            this.Cmb_Deps = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Grb_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Главный отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // Tbx_Code
            // 
            this.Tbx_Code.Location = new System.Drawing.Point(227, 133);
            this.Tbx_Code.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_Code.Name = "Tbx_Code";
            this.Tbx_Code.Size = new System.Drawing.Size(453, 26);
            this.Tbx_Code.TabIndex = 11;
            this.Tbx_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Code_KeyPress);
            this.Tbx_Code.MouseLeave += new System.EventHandler(this.Tbx_Name_MouseLeave);
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Location = new System.Drawing.Point(227, 78);
            this.Tbx_Name.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(453, 26);
            this.Tbx_Name.TabIndex = 10;
            this.Tbx_Name.TextChanged += new System.EventHandler(this.Tbx_Name_TextChanged);
            this.Tbx_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Name_KeyPress);
            this.Tbx_Name.MouseLeave += new System.EventHandler(this.Tbx_Name_MouseLeave);
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Location = new System.Drawing.Point(227, 29);
            this.Tbx_ID.Margin = new System.Windows.Forms.Padding(5);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.ReadOnly = true;
            this.Tbx_ID.Size = new System.Drawing.Size(453, 26);
            this.Tbx_ID.TabIndex = 9;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Location = new System.Drawing.Point(366, 247);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(109, 38);
            this.Btn_Ok.TabIndex = 17;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(530, 247);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(109, 38);
            this.Btn_Cancel.TabIndex = 18;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // ChBx_Base
            // 
            this.ChBx_Base.AutoSize = true;
            this.ChBx_Base.Location = new System.Drawing.Point(40, 279);
            this.ChBx_Base.Name = "ChBx_Base";
            this.ChBx_Base.Size = new System.Drawing.Size(172, 24);
            this.ChBx_Base.TabIndex = 19;
            this.ChBx_Base.Text = "Головной  отдел";
            this.ChBx_Base.UseVisualStyleBackColor = true;
            this.ChBx_Base.CheckedChanged += new System.EventHandler(this.ChBx_Base_CheckedChanged);
            // 
            // Grb_Base
            // 
            this.Grb_Base.Controls.Add(this.Cmb_Deps);
            this.Grb_Base.Controls.Add(this.label5);
            this.Grb_Base.Location = new System.Drawing.Point(6, 167);
            this.Grb_Base.Name = "Grb_Base";
            this.Grb_Base.Size = new System.Drawing.Size(657, 60);
            this.Grb_Base.TabIndex = 20;
            this.Grb_Base.TabStop = false;
            // 
            // Cmb_Deps
            // 
            this.Cmb_Deps.DisplayMember = "Name";
            this.Cmb_Deps.FormattingEnabled = true;
            this.Cmb_Deps.Location = new System.Drawing.Point(163, 19);
            this.Cmb_Deps.Name = "Cmb_Deps";
            this.Cmb_Deps.Size = new System.Drawing.Size(453, 28);
            this.Cmb_Deps.TabIndex = 17;
            this.Cmb_Deps.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(224, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Только точки и  заглавные латинские  буквы и цифры";
            // 
            // NewDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Grb_Base);
            this.Controls.Add(this.ChBx_Base);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbx_Code);
            this.Controls.Add(this.Tbx_Name);
            this.Controls.Add(this.Tbx_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(755, 363);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 363);
            this.Name = "NewDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewDepartmentForm";
            this.Grb_Base.ResumeLayout(false);
            this.Grb_Base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_Code;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.CheckBox ChBx_Base;
        private System.Windows.Forms.GroupBox Grb_Base;
        private System.Windows.Forms.ComboBox Cmb_Deps;
        private System.Windows.Forms.Label label6;
    }
}