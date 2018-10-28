using System.Collections;
using TestApp.BL.Model;

namespace TestApp.BL.Data.Repo
{
  public  interface IDepartmentRepository:IGenericRepository<Department>
    {
      
        ArrayList GetEmployeesByName(string name);
        ArrayList GetEmployeesWithDepartment();
    }
}