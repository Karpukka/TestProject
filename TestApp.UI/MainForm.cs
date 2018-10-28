using Autofac;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;
using TestApp.UI.Startup;


namespace TestApp.UI
{
    public partial class MainForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly IDepartmentRepository _departmentRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="employeeRepository"></param>
        /// <param name="departmentRepository"></param>
        public MainForm(IDepartmentRepository departmentRepository,
            IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _departmentRepository = departmentRepository;
            InitializeComponent();
            Grb_departments.Focus();
            TreeInit();

        }

        private void TreeInit()
        {
            _departmentRepository.GetAsync().ContinueWith(loadTask =>
            {
                TrList_structure.DataSource = _departmentService.GetAllDepartments();
            }, TaskScheduler.FromCurrentSynchronizationContext());
            TrList_structure.ExpandAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
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
            departmentsForm.ShowDialog();
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

        private void TrList_structure_MouseEnter(object sender, EventArgs e)
        {
            TreeInit();
        }
    }
}

