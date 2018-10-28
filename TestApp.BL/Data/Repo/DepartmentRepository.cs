using TestApp.BL.Data.Repo;
using System;
using System.Collections;
using System.Linq;
using TestApp.BL.Model;

namespace TestApp.BL.Data.Repo
{
    public class DepartmentRepository : GenericRepository<Department, CompanyDBContext>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyDBContext context) : base(context) { }



        public ArrayList GetEmployeesByName(string name)
        {
            ArrayList list = new ArrayList();
            //int age = now.Year - birthDate.Year;

            //if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            //    age--;

            //return age;

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
                   Возраст = DateTime.Now.Day - e.DateOfBirth.Day

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
            var Age = Context.Empoyees;
            var departments = Context.Departments.Join(Context.Empoyees,
               d => d.ID,
               e => e.DepartmentID,
               (d, e) => new
               {
                   e.ID,
                   Отдел = d.Name,
                   Имя = e.FirstName,
                   Фамилия = e.SurName,
                   Отчество = e.Patronymic,
                   Дата_рождения = e.DateOfBirth,
                   Серия_паспорта = e.DocSeries,
                   Номер_паспорта = e.DocNumber,
                   Должность = e.Position,
                   Возраст = (DateTime.Now.Month<e.DateOfBirth.Month ||
                   (DateTime.Now.Month==e.DateOfBirth.Month && DateTime.Now.Day < e.DateOfBirth.Day)) 
                   ?(DateTime.Now.Year -e.DateOfBirth.Year)-1 :  DateTime.Now.Year - e.DateOfBirth.Year
             
           
        });
            foreach (var item in departments)
            {
                list.Add(item);
            }
            return list;
        }

       
    }
}
