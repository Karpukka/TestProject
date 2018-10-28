using System;
using System.Drawing;
using System.Windows.Forms;
using TestApp.BL.Data.Services;

namespace TestApp.UI
{
    public partial class NewEmployeeForm : Form
    {

        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        bool flag1, flag2, flag3,flag4;
        public NewEmployeeForm(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
            Cmb_departments.DataSource = _departmentService.GetAllDepartments();
            Btn_Ok.Enabled = false;
        }
        #region Validate
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            _employeeService.AddNewEmployee(Tbx_name.Text,
               Tbx_SurName.Text, Tbx_MiddleName.Text, Dtp_Birthday.Value, Tbx_docSeries.Text,
               Tbx_docNumber.Text, Tbx_Position.Text, Guid.Parse(Cmb_departments.SelectedValue.ToString()));
            this.DialogResult = DialogResult.OK;
        }

        private void Dtp_Birthday_Leave(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - Dtp_Birthday.Value.Year) < 18)
            {
                flag4 = true;
                Btn_Ok.Enabled = false;

                Dtp_Birthday.Value = new DateTime(2000, 1, 1);
                MessageBox.Show("Сотруднику не может быть меньше 18 лет");
                return;
            }
        }

        private void Tbx_name_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

       

        private void Tbx_name_MouseLeave(object sender, EventArgs e)
        {

            if (Tbx_name.Text.Trim() == string.Empty)
            {
                flag1 = true;
                l1.Text = "Поле не должно быть пустым";
                l1.ForeColor = Color.Red;
                Btn_Ok.Enabled = false;
                return;
            }
            else { l1.Text = ""; }



            if (Tbx_SurName.Text.Trim() == string.Empty)
            {
                flag2 = true;
                l2.Text = "Поле не должно быть пустым";
                l2.ForeColor = Color.Red;
                Btn_Ok.Enabled = false;
                return;
            }
            else { l2.Text = ""; }
            if (Tbx_Position.Text.Trim() == string.Empty)
            {
                flag3 = true;
                l3.Text = "Поле не должно быть пустым";
                l3.ForeColor = Color.Red;
                Btn_Ok.Enabled = false;
                return;
            }
            else { l3.Text = ""; }

           

            if (flag1 == true || flag2 == true || flag3 == true||flag4==true)
            {
                Btn_Ok.Enabled = true;
            }

        }

        private void Tbx_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
