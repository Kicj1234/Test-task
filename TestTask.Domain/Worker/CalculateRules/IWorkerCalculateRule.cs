using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Domain.Worker.CalculateRules
{
    public interface IWorkerCalculateRule
    {
        decimal CalculateOnDate(IWorkerSalaryFactory factory, Worker workerComp, DateTime onDate);
    }
}
