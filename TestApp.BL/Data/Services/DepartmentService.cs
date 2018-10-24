using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TestApp.Dal.Model;
using TestApp.BL.Data.Repo;

namespace TestApp.BL.Data.Services
{
    public  class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public ArrayList GetAllDepartments()
        {
            ArrayList list = new ArrayList();
            var items =_departmentRepository.Get();
            foreach (var item in items)
            {
                list.Add(item);
            }
            return list;
        }

        public List<string> GetBaseDepartment(Guid value)
        {
           List<string> departmentName = new List<string>();
            var departments = _departmentRepository.Get().Where(d => d.ID == value);

            foreach (var deps in departments)
            {
                departmentName.Add(deps.Name);
            }
            return departmentName;
        }





        public List<string> GetAllBranches(Guid? value)
        {
            List<string> departmentName = new List<string>();
            var departments = _departmentRepository.Get().Where(d => d.ParentDepartmentID == value);

            foreach (var deps in departments)
            {
                departmentName.Add(deps.Name);
            }
            return departmentName;
        }
        public ArrayList GetAllBranchesFullInfo(Guid? value)
        {
            ArrayList departmentsList = new ArrayList();
            var departments = _departmentRepository.Get().Where(d => d.ParentDepartmentID == value);

            foreach (var deps in departments)
            {
                departmentsList.Add(deps);
            }
            return departmentsList;
        }
        public void RemoveDepartment(Guid id)
        {
            Department department = _departmentRepository.FindById(id);
            _departmentRepository.Remove(department);
        }
        public void AddNewDepartment(Guid id, string name, string code,
            Guid? parentDepartmentId=null)
        {
            Department department = new Department
            {
                ID =id,
                Name =name,
                Code=code,
                ParentDepartmentID = parentDepartmentId
            };
            _departmentRepository.Add(department);

        }

        public void UpdateDepartment(Guid id, string name, string code,
            Guid? parentDepartmentId = null)
        {
            Department department = _departmentRepository.FindById(id);
            department.ID = id;
            department.Name = name;
            department.Code = code;
            department.ParentDepartmentID = parentDepartmentId;
            _departmentRepository.Update(department);
        }
    }
}
