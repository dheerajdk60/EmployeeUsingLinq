using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace linqemployee.Model
{
    [System.Data.Linq.Mapping.Table(Name="employees")]
    class Employee
    {
         [Column(IsPrimaryKey =true)]
        public int Id { get; set; }
        [System.Data.Linq.Mapping.Column]
        public string Name { get; set; }
        [System.Data.Linq.Mapping.Column]
        public string City { get; set; }
    }
}
