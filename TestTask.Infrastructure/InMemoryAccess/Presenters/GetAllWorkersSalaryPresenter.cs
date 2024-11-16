using TestTask.Application.Boundaries.GetAllWorkersSalary;
using TestTask.Domain.Worker;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Infrastructure.InMemoryAccess.Presenters
{
    public class GetAllWorkersSalaryPresenter : IOutputPort
    {
        public decimal AllSalariesSum;
        public void Output(GetAllWorkersSalaryOutput output)
        {
            AllSalariesSum = output.SalarySum;
        }
    }
}
