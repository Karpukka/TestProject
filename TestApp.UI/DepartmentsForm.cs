using Autofac;
using System;
using System.Drawing;
using System.Windows.Forms;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;
using TestApp.UI.Startup;
using System.Data.Entity;
using DevExpress.XtraTreeList.Columns;

namespace TestApp.UI
{
    public partial class DepartmentsForm : Form
    {

        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IDepartmentRepository _departmentRepository;
        bool flag1, flag2;
        public DepartmentsForm(IDepartmentService departmentService,
            IDepartmentRepository departmentRepository,
            IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _departmentRepository = departmentRepository;
            InitializeComponent();
            Dgw_departments.DataSource = _departmentService.GetAllDepartments();
            DgwDepartments_Settings();
            Grb_Base.Visible = false;
            TrList_structure.DataSource = _departmentService.GetAllDepartments();

            TreeViewInit();
        }

      

        #region Settings
        private void DgwDepartments_Settings()
        {
            Dgw_departments.TopLeftHeaderCell.Value = "#";
            Dgw_departments.Columns["Department1"].Visible = false;
            Dgw_departments.Columns["Department2"].Visible = false;
            Dgw_departments.Columns["Empoyees"].Visible = false;
            TrList_structure.ExpandAll();
        }
        private void TreeViewInit()
        {
            _departmentRepository.GetAsync().ContinueWith(loadTask =>
            {
                TrList_structure.DataSource = _departmentService.GetAllDepartments();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            TrList_structure.ExpandAll();
        }
        #endregion

        private void Dgw_departments_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Lbx_Base_Dep.DataSource = null;


            try
            {
                Tbx_ID.Text = Dgw_departments.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                Tbx_Name.Text = Dgw_departments.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                Tbx_Code.Text = Dgw_departments.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                Lbx_Base_Dep.DataSource = _departmentService
                     .GetBaseDepartment(Guid
                     .Parse(Dgw_departments
                     .Rows[e.RowIndex]
                     .Cells["ParentDepartmentID"]
                     .Value.ToString()));

            }
            catch { }


        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var bootstraper = new BootStraper();
                var container = bootstraper.Bootstrap();
                var departmentsForm = container.Resolve<NewDepartmentForm>();
                if (departmentsForm.ShowDialog() == DialogResult.OK)
                {
                    Dgw_departments.DataSource = _departmentService.GetAllDepartments();
                    TreeViewInit();
                    MessageBox.Show("Новый отдел успешно добавлен",
                        "Departments Operations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Отдел не добавлен !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                throw new NullReferenceException(ex.Message);
            }
        }
        /// <summary>
        /// Удалить отдел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgw_departments.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Вы уверены , что хотите удалить отдел?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _departmentService.RemoveDepartment(Guid.Parse(Tbx_ID.Text.Trim()));
                        Dgw_departments.DataSource = _departmentService.GetAllDepartments();
                        TreeViewInit();
                        MessageBox.Show("Отдел удален");
                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Невозможно удалить отдел вместе с сотрудниками, работающими в этом отделе","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }



        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            string name = Tbx_Name.Text;
            if (MessageBox.Show("Вы уверены , что хотите внести изменения?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Cmb_Deps.Text != Tbx_Name.Text)
                {
                    _departmentService.UpdateDepartment(Guid.Parse(Tbx_ID.Text),
                                   Tbx_Name.Text, Tbx_Code.Text, Cmb_Deps.SelectedValue as Guid?);
                    Dgw_departments.DataSource = _departmentService.GetAllDepartments();
                    TreeViewInit();
                    Chkb_Base.Checked = false;
                    MessageBox.Show("Отдел  " + name + " успешно изменен");
                }
                else
                {
                    MessageBox.Show("Нельзя зацикливать отделы по родителю - нехорошо.", "Danger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }
        private void Chkb_Base_CheckedChanged(object sender, EventArgs e)
        {
            if (!Chkb_Base.Checked)
            {
                Grb_Base.Visible = false;
                Cmb_Deps.Text = "";
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
        #region Validate
        /// <summary>
        /// Певая буква заглавная
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_Name_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        /// <summary>
        /// Только заглвные латинские буквы и ццифры в поле "КОД"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'Z') && l != '\b' && l != '.' && l != 8 && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }

        }

        private void Tbx_Name_MouseLeave(object sender, EventArgs e)
        {
            if (Tbx_Name.Text.Trim() == string.Empty)
            {
                flag1 = true;
                label3.Text = "Поле не заполнено";
                label3.ForeColor = Color.Red;
                Btn_Change.Enabled = false;
                return;
            }
            else { label3.Text = "Название"; label3.ForeColor = Color.Black; }

            if (Tbx_Code.Text.Trim() == string.Empty)
            {
                flag2 = true;
                label4.Text = "Поле не заполнено";
                label4.ForeColor = Color.Red;
                Btn_Change.Enabled = false;
                return;
            }
            else { label4.Text = "Kод"; label4.ForeColor = Color.Black; }

            if (flag1 == true || flag2 == true)
            {
                Btn_Change.Enabled = true;
            }
        }

        private void TrList_structure_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Dgw_departments.Rows.Count; i++)
            {
                if (Dgw_departments.Rows[i].Cells["Name"].Value.ToString() == TrList_structure.FocusedNode["Name"].ToString() )
                {
                    Dgw_departments.Rows[i].Selected = true;
                    Lbx_Base_Dep.DataSource = null;


                    try
                    {
                        Tbx_ID.Text = Dgw_departments.Rows[i].Cells["ID"].Value.ToString();
                        Tbx_Name.Text = Dgw_departments.Rows[i].Cells["Name"].Value.ToString();
                        Tbx_Code.Text = Dgw_departments.Rows[i].Cells["Code"].Value.ToString();
                        Lbx_Base_Dep.DataSource = _departmentService
                             .GetBaseDepartment(Guid
                             .Parse(Dgw_departments
                             .Rows[i]
                             .Cells["ParentDepartmentID"]
                             .Value.ToString()));


                    }
                    catch { }
                }
            }
        }

        private void Tbx_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.' && l != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

      
    }
}
