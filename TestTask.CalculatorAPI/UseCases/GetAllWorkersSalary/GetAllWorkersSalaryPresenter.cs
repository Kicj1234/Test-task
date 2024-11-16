using Aspose.Application.Boundaries.GetAllWorkersSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.CalculatorAPI.UseCases.GetAllWorkersSalary
{
    public class GetAllWorkersSalaryPresenter : IOutputPort
    {
        public decimal Salary { get; set; }
        public void Output(GetAllWorkersSalaryOutput output)
        {
            Salary = output.SalarySum;
        }
    }
}