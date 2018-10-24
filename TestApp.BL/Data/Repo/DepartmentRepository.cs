using TestApp.BL.Data.Repo;
using System;
using System.Collections;
using System.Linq;
using TestApp.Dal.Model;

namespace TestApp.BL.Data.Repo
{
    public class DepartmentRepository : GenericRepository<Department, CompanyDBContext>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyDBContext context) : base(context) { }

        
        
        public ArrayList GetEmployeesByName(string name)
        {
            ArrayList list = new ArrayList();
            var departments = Context.Departments.Join(Context.Empoyees,
               d => d.ID,
               e => e.DepartmentID,
               (d, e) => new
               {
                   e.ID,
                   Отдел = d.Name,
                   Имя = e.FirstName,
                    e.SurName,
                   Отчество = e.Patronymic,
                   Дата_рождения = e.DateOfBirth,
                   Серия_паспорта = e.DocSeries,
                   Номер_паспорта = e.DocNumber,
                   Должность = e.Position,
                   Возраст = DateTime.Now.Year - e.DateOfBirth.Year
               }).Where(e => e.SurName == name);
            foreach (var item in departments)
            {
                list.Add(item);
            }
            return list;

        }
        public ArrayList GetEmployeesWithDepartment()
        {
            ArrayList list = new ArrayList();
            var departments = Context.Departments.Join(Context.Empoyees,
               d => d.ID,
               e => e.DepartmentID,
               (d, e) => new
               {
                   e.ID,
                   Отдел = d.Name,
                   Имя = e.FirstName,
                   Фамилия= e.SurName,
                   Отчество = e.Patronymic,
                   Дата_рождения = e.DateOfBirth,
                   Серия_паспорта = e.DocSeries,
                   Номер_паспорта = e.DocNumber,
                   Должность = e.Position,
                   Возраст = DateTime.Now.Year - e.DateOfBirth.Year
               });
            foreach (var item in departments)
            {
                list.Add(item);
            }
            return list;
        }

        public ArrayList GetEmployeesByDepartment(string name)
        {
            ArrayList list = new ArrayList();
            var departments = Context.Departments.Join(Context.Empoyees,
               d => d.ID,
               e => e.DepartmentID,
               (d, e) => new
               {
                   d.Name,
                   Имя = e.FirstName,
                   Фамилия = e.SurName,
                   Отчество = e.Patronymic,
                   Дата_рождения = e.DateOfBirth,
                   Серия_паспорта = e.DocSeries,
                   Номер_паспорта = e.DocNumber,
                   Должность = e.Position,
                   Возраст = DateTime.Now.Year- e.DateOfBirth.Year 
               }).Where(e=>e.Name == name);
            foreach (var item in departments)
            {
                list.Add(item);
            }
            return list;

        }

    }
}
