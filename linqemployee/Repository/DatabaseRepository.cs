using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using linqemployee.Model;
using System.Data;

namespace linqemployee.Repository
{
    class DatabaseRepository
    {
        SQLiteConnection con ;
        DataContext context;
        Table<Employee> employees;

        public DatabaseRepository()
        {
            con = new SQLiteConnection(@"Data Source=D:\Capillary\sqlite_databases\company.db");
            context = new DataContext(con);
            employees = context.GetTable<Employee>();
        }

        internal object getAll()
        {
            return from emp in employees select emp;
        }

        internal void addEmployee(string name, string city)
        {

            Employee employee = new Employee();
            employee.Name = name;
            employee.City = city;
            var IdQuery = from emp in employees select emp;
            try
            {
                employee.Id = IdQuery.ToList().Last().Id + 1;
            }
            catch
            {
                employee.Id = 1;
            }
            employees.InsertOnSubmit(employee);
            context.SubmitChanges();
        }

        internal void updateEmployee(string name, string city, string id)
        {
            var results = from emp in employees where emp.Id == Convert.ToInt32(id) select emp ;
            foreach(var employee in results)
            {
                if (!string.IsNullOrEmpty(name))
                    employee.Name = name;
                if (!string.IsNullOrEmpty(city))
                    employee.City = city;
            }
            context.SubmitChanges();
        }

        internal object findByOptions(string name, string city)
        {
            
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(city))
            {
                return from emp in employees where emp.City == city && emp.Name==name select emp ;
            }
            else if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(city))
            {
                return null;
            }
            else if (!string.IsNullOrEmpty(name))
            {
                return from emp in employees where emp.Name == name select emp;
            }
            else
            {
                return from emp in employees where emp.City == city select emp;
            }


        }

        internal void deleteEmployee(string name,string city,string id)
        {
            var employee = from emp in employees select emp ;
            if (!string.IsNullOrEmpty(id))
            {
                 employee = (from emp in employees where emp.Id == Convert.ToInt32(id) select emp); //employees.Where(e => e.Name == name).ToList().First();
            }
            else if(!string.IsNullOrEmpty(name)&& !string.IsNullOrEmpty(city))
            {
                employee = (from emp in employees where emp.Name == name && emp.City==city select emp);
            }
            else if (!string.IsNullOrEmpty(name))
            {
                employee = (from emp in employees where emp.Name == name select emp);
            }
            else if (!string.IsNullOrEmpty(city))
            {
                employee = (from emp in employees where emp.City == city select emp);
            }

            employees.DeleteAllOnSubmit(employee);
            context.SubmitChanges();
        }
    }
}
