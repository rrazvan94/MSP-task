using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EmployeeDbConnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
