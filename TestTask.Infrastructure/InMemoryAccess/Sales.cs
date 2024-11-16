using TestTask.Domain.Worker;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Infrastructure.InMemoryAccess
{
    public class Sales : Domain.Worker.Sales.Sales
    {
        public Sales(Guid id, string name, decimal salary, DateTime empl, IEnumerable<Worker> children)
        {
            base.Id = id;
            base.Name = name;
            base.Salary = salary;
            base.EmploymentDate = empl;
            base.Children = children;
        }
}
}
