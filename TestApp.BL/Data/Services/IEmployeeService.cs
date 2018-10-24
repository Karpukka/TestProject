using System;
using System.Collections;

namespace TestApp.BL.Data.Services
{
    public interface IEmployeeService
    {
        ArrayList GetAllEmployees();

        void AddNewEmployee(string firstName, string surName, string patronimic,
           DateTime dateOfBirth, string docSeries,
       string docNumber, string position, Guid departmentId);

        void RemoveEmployee(int id);

        void UpdateEmployee(int id, string firstName,
        string surName, string patronimic,
        DateTime dateOfBirth, string docSeries,
    string docNumber, string position,
    Guid departmentId);


    }
}