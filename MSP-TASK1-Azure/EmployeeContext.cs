using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP_TASK1_Azure
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EmployeeDbConnectionString")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
