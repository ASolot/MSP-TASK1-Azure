using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeID, string firstName, string lastName,
                            string address, int age, double salary)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
            Salary = salary;
        }

        public Employee()
        {

        }
    }
}

