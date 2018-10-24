using System;
using System.Drawing;
using System.Windows.Forms;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;

namespace TestApp.UI
{
    public partial class NewDepartmentForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly IDepartmentRepository _departmentRepository;
        bool flag1, flag2;

        public NewDepartmentForm(IDepartmentService departmentService,
            IDepartmentRepository departmentRepository)
        {
            _departmentService = departmentService;
            _departmentRepository = departmentRepository;
            InitializeComponent();
            Grb_Base.Visible = false;
            Tbx_ID.Text = Guid.NewGuid().ToString();
            Btn_Ok.Enabled = false;
        }

        private void ChBx_Base_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChBx_Base.Checked)
            {
                Grb_Base.Visible = false;
                Cmb_Deps.Text="";
                Cmb_Deps.ValueMember = "ID";
                Cmb_Deps.DisplayMember = "Name";
            }
            else
            {
                Grb_Base.Visible = true;

                Cmb_Deps.DataSource = _departmentService.GetAllDepartments();
                Cmb_Deps.ValueMember = "ID";
                Cmb_Deps.DisplayMember = "Name";
            }
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            _departmentService.AddNewDepartment(Guid.Parse(Tbx_ID.Text),
                Tbx_Name.Text,Tbx_Code.Text , Cmb_Deps.SelectedValue as Guid?);
        }

        private void Tbx_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.' && l != 8)
            {
                e.Handled = true;
            }
        }

        private void Tbx_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'Z') && l != '\b' && l != '.' && l != 8 && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }
        }

        private void Tbx_Name_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void Tbx_Name_MouseLeave(object sender, EventArgs e)
        {
            if (Tbx_Name.Text.Trim() == string.Empty)
            {
                flag1 = true;
                label3.Text = "Поле не заполнено";
                label3.ForeColor = Color.Red;
                Btn_Ok.Enabled = false;
                return;
            }
            else { label3.Text = "Название"; label3.ForeColor = Color.Black; }

            if (Tbx_Code.Text.Trim() == string.Empty)
            {
                flag2 = true;
                label4.Text = "Поле не заполнено";
                label4.ForeColor = Color.Red;
                Btn_Ok.Enabled = false;
                return;
            }
            else { label4.Text = "Kод"; label4.ForeColor = Color.Black; }

            if (flag1 == true || flag2 == true)
            {
                Btn_Ok.Enabled = true;
            }
        }

      
    }
}
