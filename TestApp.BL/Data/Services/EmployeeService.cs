using System;
using System.Collections;
using TestApp.BL.Model;
using TestApp.BL.Data.Repo;

namespace TestApp.BL.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }
        public ArrayList GetAllEmployees()
        {
            ArrayList departmentsList = new ArrayList();
            var deps = _employeeRepository.Get();
            foreach (var departments in deps)
            {
                departmentsList.Add(deps);
            }
            return departmentsList;
        }



        public void AddNewEmployee(string firstName, string surName, string patronimic,
           DateTime dateOfBirth, string docSeries,
       string docNumber, string position, Guid departmentId)
        {
            Empoyee empoyee = new Empoyee
            {
                FirstName = firstName,
                SurName = surName,
                Patronymic = patronimic,
                DateOfBirth = dateOfBirth,
                DocSeries = docSeries,
                DocNumber = docNumber,
                Position = position,
                DepartmentID = departmentId
            };
            _employeeRepository.Add(empoyee);

        }

        public void RemoveEmployee(int id)
        {
            Empoyee empoyee = _employeeRepository.FindById(id);
            _employeeRepository.Remove(empoyee);
        }


        public void UpdateEmployee(int id, string firstName,
         string surName, string patronimic,
         DateTime dateOfBirth, string docSeries,
     string docNumber, string position,
     Guid departmentId)
        {
            Empoyee empoyee = _employeeRepository.FindById(id);
            empoyee.FirstName = firstName;
            empoyee.SurName = surName;
            empoyee.Patronymic = patronimic;
            empoyee.DateOfBirth = dateOfBirth;
            empoyee.DocSeries = docSeries;
            empoyee.DocNumber = docNumber;
            empoyee.Position = position;
            empoyee.DepartmentID = departmentId;
            _employeeRepository.Update(empoyee);
        }
    }
}

