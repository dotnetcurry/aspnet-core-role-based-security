using System.Collections.Generic;

namespace Core_RBS.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }

    public class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() {EmpNo=101,EmpName="Emp-1",Salary=1200});
            Add(new Employee() { EmpNo = 102, EmpName = "Emp-2", Salary = 2200 });
        }
    }

}
