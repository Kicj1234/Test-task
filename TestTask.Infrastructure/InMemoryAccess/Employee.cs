using TestTask.Domain.Worker;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Infrastructure.InMemoryAccess
{
    public class Employee : Domain.Worker.Employee.Employee
    {
        public Employee(Guid id, string name, decimal salary, DateTime empl)
        {
            base.Id = id;
            base.Name = name;
            base.Salary = salary;
            base.EmploymentDate = empl;
        }
    }
}
