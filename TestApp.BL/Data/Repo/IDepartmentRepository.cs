using System.Collections;
using TestApp.Dal.Model;

namespace TestApp.BL.Data.Repo
{
  public  interface IDepartmentRepository:IGenericRepository<Department>
    {
      
        ArrayList GetEmployeesByName(string name);

        ArrayList GetEmployeesByDepartment(string name);
        ArrayList GetEmployeesWithDepartment();
    }
}