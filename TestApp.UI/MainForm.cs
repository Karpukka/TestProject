using Autofac;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;
using TestApp.UI.Startup;

namespace TestApp.UI
{
    public partial class MainForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="employeeRepository"></param>
        /// <param name="departmentRepository"></param>
        public MainForm(IEmployeeRepository employeeRepository,
            IDepartmentService departmentService,
            IDepartmentRepository departmentRepository,
            IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dgw_Departments.DataSource = _departmentService.GetAllDepartments();
            Dgw_Settings();
        }
        /// <summary>
        /// Настройки датагрид
        /// </summary>
        private void Dgw_Settings()
        {

            Dgw_Departments.TopLeftHeaderCell.Value = "#";
            Dgw_Departments.Columns["ID"].Visible = false;
            Dgw_Departments.Columns["ParentDepartmentID"].Visible = false;
            Dgw_Departments.Columns["Department1"].Visible = false;
            Dgw_Departments.Columns["Department2"].Visible = false;
            Dgw_Departments.Columns["Code"].Visible = false;
            Dgw_Departments.Columns["Empoyees"].Visible = false;
        }
        
        /// <summary>
        /// Выбор варианта поиска сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void Btn_Change_Employees_Click(object sender, EventArgs e)
        {
            var bootstraper = new BootStraper();
            var container = bootstraper.Bootstrap();
            var userForm = container.Resolve<UsersForm>();
            userForm.Show();
        }

        private void Btn_Change_Departments_Click(object sender, EventArgs e)
        {
            var bootstraper = new BootStraper();
            var container = bootstraper.Bootstrap();
            var departmentsForm = container.Resolve<DepartmentsForm>();
            departmentsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите покинуть приложение??", "Company Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

       
    }
}
