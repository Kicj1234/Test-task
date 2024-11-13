using Aspose.Domain.Worker.CalculateRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Domain.Worker.CalculateRules.Rules
{
    public class Base3prYear30Max : IWorkerCalculateRule
    {
        public decimal CalculateOnDate(IWorkerSalaryFactory factory, Worker worker, DateTime onDate)
        {
            if (onDate < worker.EmploymentDate) throw new OnDateGreaterException();

            var res = 3 * (decimal)Math.Truncate((onDate - worker.EmploymentDate).TotalDays / 365);

            if (res > 30)
                res = 30;

            return worker.Salary + ((worker.Salary / 100) * res);
        }
    }
}
