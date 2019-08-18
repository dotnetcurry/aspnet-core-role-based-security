using Core_RBS.Models;
using System.Collections.Generic;
namespace Core_RBS.Services
{
    public class EmployeeService
    {
        Employees emps;

        public EmployeeService(Employees emps)
        {
            this.emps = emps;
        }
        public List<Employee> Get()
        {
            return emps;
        }

        public List<Employee> Create(Employee emp)
        {
            emps.Add(emp);
            return emps;
        }
    }
}
