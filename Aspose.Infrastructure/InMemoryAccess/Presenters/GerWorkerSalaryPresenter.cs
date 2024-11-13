using Aspose.Application.Boundaries.GetWorkerSalary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Infrastructure.InMemoryAccess.Presenters
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
