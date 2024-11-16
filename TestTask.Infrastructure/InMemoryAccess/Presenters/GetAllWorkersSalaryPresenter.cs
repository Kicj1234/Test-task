using Aspose.Application.Boundaries.GetAllWorkersSalary;
using Aspose.Domain.Worker;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Infrastructure.InMemoryAccess.Presenters
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
