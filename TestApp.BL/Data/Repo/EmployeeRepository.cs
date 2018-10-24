using TestApp.BL.Data.Repo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Dal.Model;
using System.Data.Entity;

namespace TestApp.BL.Data.Repo
{
   public class EmployeeRepository:GenericRepository<Empoyee, CompanyDBContext>,IEmployeeRepository
    {
        public EmployeeRepository(CompanyDBContext context) : base(context) { }
    }
}
