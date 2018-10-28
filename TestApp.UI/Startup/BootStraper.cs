using Autofac;
using TestApp.BL.Model;
using TestApp.BL.Data.Repo;
using TestApp.BL.Data.Services;
using IContainer = Autofac.IContainer;

namespace TestApp.UI.Startup
{
    class BootStraper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CompanyDBContext>().AsSelf();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<DepartmentService>().As<IDepartmentService>();

            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<UsersForm>().AsSelf();
            builder.RegisterType<DepartmentsForm>().AsSelf();
            builder.RegisterType<NewEmployeeForm>().AsSelf();
            builder.RegisterType<NewDepartmentForm>().AsSelf();
            
            
            return builder.Build();
        }
    }
}
