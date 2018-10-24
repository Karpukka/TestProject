using Autofac;
using System;
using System.Drawing;
using System.Windows.Forms;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;
using TestApp.UI.Startup;

namespace TestApp.UI
{
    public partial class UsersForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IDepartmentRepository _departmentRepository;

        private int Id { get; set; }

        public UsersForm(IDepartmentService departmentService,
            IDepartmentRepository departmentRepository, IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _departmentRepository = departmentRepository;

            InitializeComponent();
            Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesWithDepartment();
            Cmb_departments.DataSource = _departmentService.GetAllDepartments();
            Lbx_Emp_details.Columns["ID"].Visible = false;

        }



        private void UsersForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Add_new_employee_Click(object sender, EventArgs e)
        {

            try
            {
                var bootstraper = new BootStraper();
                var container = bootstraper.Bootstrap();
                var userForm = container.Resolve<NewEmployeeForm>();
                if (userForm.ShowDialog() == DialogResult.OK)
                {
                    Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesWithDepartment();
                    MessageBox.Show("Новый сотрудник успешно добавлен",
                        "Employees Operations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Сотрудник не добавлен !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                throw new NullReferenceException(ex.Message);
            }

        }

        private void Lbx_Emp_details_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeDataBinding(e);
        }

        private void EmployeeDataBinding(DataGridViewCellEventArgs e)
        {
            Tbx_name.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbx_SurName.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (String.IsNullOrEmpty(Lbx_Emp_details.Rows[e.RowIndex].Cells[4].Value as String)) { Tbx_MiddleName.Text = "Нет данных"; }
            else { Tbx_MiddleName.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[4].Value.ToString(); }
            Dtp_Birthday.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[5].Value.ToString();
            Tbx_docSeries.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[6].Value.ToString();
            Tbx_docNumber.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[7].Value.ToString();
            Tbx_Position.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[8].Value.ToString();
            Cmb_departments.Text = Lbx_Emp_details.Rows[e.RowIndex].Cells[1].Value.ToString();
            Id = int.Parse(Lbx_Emp_details.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (Lbx_Emp_details.SelectedRows.Count > 0)
            {
                _employeeService.RemoveEmployee(Id);
                Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesWithDepartment();
                MessageBox.Show("Сотрудник удален");
            }
        }

        private void Btn_Change_Employee_Click(object sender, EventArgs e)
        {
            string name = Tbx_SurName.Text + "  " + Tbx_name.Text;
            if (MessageBox.Show("Вы действительно хотите внести изменения ?", "Company Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _employeeService.UpdateEmployee(Id, Tbx_name.Text,
                Tbx_SurName.Text, Tbx_MiddleName.Text,
                Dtp_Birthday.Value, Tbx_docSeries.Text,
                Tbx_docNumber.Text, Tbx_Position.Text,
                Guid.Parse(Cmb_departments.SelectedValue.ToString()));
                Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesWithDepartment();
                MessageBox.Show("Данные сотрудника  -  " + name + "  успешно изменены");
            }
            else
            {
                MessageBox.Show("Ошибка");
                return;
            }
        }


        /// <summary>
        /// Поиск сотрудника по фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (Tbx_Search.Text.Length > 0)
            {
                // Lbx_Emp_details.Columns.Clear();
                foreach (DataGridViewRow item in Lbx_Emp_details.Rows)
                {
                    if (item.Cells[3].Value.ToString() == Tbx_Search.Text) { flag = true; }
                }
                if (flag == true)
                {
                    Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesByName(Tbx_Search.Text);
                }
                else
                {
                    MessageBox.Show("Такого сотрудника нет");
                }
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым");
                Tbx_Search.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        /// <summary>
        /// Показать всех
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ALL_employees_Click(object sender, EventArgs e)
        {
            Lbx_Emp_details.Columns.Clear();
            Lbx_Emp_details.DataSource = _departmentRepository.GetEmployeesWithDepartment();
        }
       
        
        /// <summary>
        /// Только буквы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_name1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Текст с заглавной буквы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_name_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
        /// <summary>
        /// Валидация текстовых полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_name_MouseLeave(object sender, EventArgs e)
        {
            if (Tbx_name.Text.Trim() == string.Empty)
            {
                l1.Text = "Поле не должно быть пустым";
                l1.ForeColor = Color.Red;
                Btn_Change_Employee.Enabled = false;
                return;
            }
            if (Tbx_SurName.Text.Trim() == string.Empty)
            {
                l2.Text = "Поле не должно быть пустым";
                l2.ForeColor = Color.Red;
                Btn_Change_Employee.Enabled = false;
                return;
            }
            if (Tbx_Position.Text.Trim() == string.Empty)
            {
                l3.Text = "Поле не должно быть пустым";
                l3.ForeColor = Color.Red;
                Btn_Change_Employee.Enabled = false;
                return;
            }
            else
            {
                l1.Text = "";
                l2.Text = "";
                l3.Text = "";
                Btn_Change_Employee.Enabled = true;
            }
        }
    }
}
