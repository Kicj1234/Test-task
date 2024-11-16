using Aspose.Application.Boundaries.GetWorkerSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.CalculatorAPI.UseCases.GetWorkerSalary
{
    public class GetWorkerSalaryPresenter : IOutputPort
    {
        public decimal Salary { get; set; }
        public void Output(GetWorkerSalaryOutput output)
        {
            Salary = output.Salary;
        }
    }
}
