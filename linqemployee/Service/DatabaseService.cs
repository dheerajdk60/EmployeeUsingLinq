using linqemployee.Model;
using linqemployee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqemployee.Service
{
    class DatabaseService
    {
        DatabaseRepository databaseRepository = new DatabaseRepository();

        internal void addEmployee(string Name, string City)
        {
            databaseRepository.addEmployee(Name,City);
        }

        internal void deleteEmployee(string name,string city,string id)
        {
            databaseRepository.deleteEmployee(name,city,id);
        }

        internal object getAll()
        {
           return  databaseRepository.getAll();
        }

        internal object findByOptions(string name, string city)
        {
            return databaseRepository.findByOptions(name,city);
        }

        internal void updateEmployee(string name, string city, string id)
        {
            databaseRepository.updateEmployee(name,city,id);
        }
    }
}
