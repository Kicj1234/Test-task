using TestTask.Application.Boundaries.GetWorkerSalary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Infrastructure.InMemoryAccess.Presenters
{
    public class GerWorkerSalaryPresenter : IOutputPort
    {
        public decimal Salary { get; set; }
        public void Output(GetWorkerSalaryOutput output)
        {
            Salary = output.Salary;
        }
    }
}
