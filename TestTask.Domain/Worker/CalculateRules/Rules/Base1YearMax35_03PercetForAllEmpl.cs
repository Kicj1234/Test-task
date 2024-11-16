using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker.CalculateRules.Rules
{
    public class Base1YearMax35_03PercetForAllEmpl : IWorkerCalculateRule
    {
        public int HowDeepToCalculte => 1;
        public decimal CalculateOnDate(IWorkerSalaryFactory factory, Worker worker, DateTime onDate)
        {
            if (onDate < worker.EmploymentDate) throw new OnDateGreaterException();

            List<Worker> workers = new List<Worker>();
            GetAllWorkers(worker, workers);
            workers.Remove(worker);
            decimal sumSalary = default;
            foreach(var workerInLst in workers)
                sumSalary  += factory.GetCalculator(workerInLst).CalculateOnDate(factory, workerInLst, onDate) / 100 * (decimal)0.3;

            var res = 1 * (decimal)Math.Truncate((onDate - worker.EmploymentDate).TotalDays / 365);

            if (res > 35)
                res = 35;

            return worker.Salary + ((worker.Salary / 100) * res) + sumSalary;
        }

        private void GetAllWorkers(Worker worker, List<Worker> workersRes)
        {
            if (worker.Children != null && worker.Children.Count() > 0)
            {
                foreach (var wrkr in worker.Children)
                    GetAllWorkers(wrkr, workersRes);
            }

            if (!workersRes.Any(x => x.Id == worker.Id))
                workersRes.Add(worker);
        }
    }
}

