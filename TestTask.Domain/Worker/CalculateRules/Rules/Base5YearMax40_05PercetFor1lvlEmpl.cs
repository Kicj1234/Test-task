using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker.CalculateRules.Rules
{
    public class Base5YearMax40_05PercetFor1lvlEmpl : IWorkerCalculateRule
    {
        public int HowDeepToCalculte => 1;
        public decimal CalculateOnDate(IWorkerSalaryFactory factory, Worker workerComp, DateTime onDate)
        {
            if (onDate < workerComp.EmploymentDate) throw new OnDateGreaterException();

            decimal resLayers = default;
            foreach (var wrkr in workerComp.Children)
                resLayers += factory.GetCalculator(wrkr).CalculateOnDate(factory, wrkr, onDate) / 200;

            var res = 5 * (decimal)Math.Truncate((onDate - workerComp.EmploymentDate).TotalDays / 365);

            if (res > 40)
                res = 40;

            return workerComp.Salary + ((workerComp.Salary / 100) * res) + resLayers;
        }
    }
}
