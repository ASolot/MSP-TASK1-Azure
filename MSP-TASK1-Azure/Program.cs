using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP_TASK1_Azure
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeContext = new EmployeeContext();

            employeeContext.Employees.Add(new Employee()
            {
                FirstName = "Roger",
                LastName = "Federer",
                Address = "Basel, Switzerland",
                Age = 35,
                Salary = 4800
            });

            employeeContext.SaveChanges();

            foreach (var employee in employeeContext.Employees)
                Console.WriteLine(employee.LastName);

            var roger = employeeContext.Employees.Where(e => e.LastName == "Federer");
        }
    }
}
