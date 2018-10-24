using System;
using System.Collections;
using System.Collections.Generic;

namespace TestApp.BL.Data.Services
{
    public  interface IDepartmentService
    {
        ArrayList GetAllDepartments();
        List<string> GetAllBranches(Guid? value);
        ArrayList GetAllBranchesFullInfo(Guid? value);
        List<string> GetBaseDepartment(Guid value);

        void AddNewDepartment(Guid id, string name, string code, Guid? parentDepartmentId);
       void RemoveDepartment(Guid id);

        void UpdateDepartment(Guid id, string name, string code,
            Guid? parentDepartmentId = null);
    }
}
