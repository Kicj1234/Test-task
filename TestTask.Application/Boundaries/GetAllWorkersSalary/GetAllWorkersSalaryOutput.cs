using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Application.Boundaries.GetAllWorkersSalary
{
    public sealed class GetAllWorkersSalaryOutput
    {
        public GetAllWorkersSalaryOutput(decimal salarySum)
        {
            this.SalarySum = salarySum;
        }

        public decimal SalarySum { get; }
    }
}
