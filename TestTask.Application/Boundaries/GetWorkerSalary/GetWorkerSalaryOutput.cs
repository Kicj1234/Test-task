using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Application.Boundaries.GetWorkerSalary
{
    public class GetWorkerSalaryOutput
    {
        public decimal Salary { get; }
        public GetWorkerSalaryOutput(decimal salary)
        {
            Salary = salary;
        }
    }
}
