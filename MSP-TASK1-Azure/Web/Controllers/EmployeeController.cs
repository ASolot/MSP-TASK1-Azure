using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Hubs;
using WebApp.Models;

namespace Web.Controllers
{
    public class EmployeeController : ApiController
    {

        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(5, "Gheorghe", "Praschiv", "BR5", 25, 123)
        };

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        [HttpPost]
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            GlobalHost.ConnectionManager.
                GetHubContext<EmployeeHub>().Clients.All.publishEmployee(employee);
        }
    }
}
