using TestTask.Domain.Worker;
using TestTask.Domain.Worker.CalculateRules;
using TestTask.Domain.Worker.CalculateRules.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.ConsoleUI
{
    public class WorkerSalaryFactory : IWorkerSalaryFactory
    {
        public IWorkerCalculateRule GetCalculator(Worker worker)
        {
            var workType = worker.GetType().Name;

            switch (workType)
            {
                case "Employee":
                    return new Base3prYear30Max();
                case "Sales":
                    return new Base1YearMax35_03PercetForAllEmpl();
                case "Manager":
                    return new Base5YearMax40_05PercetFor1lvlEmpl();
                default:
                    throw new SalaryRuleNotFound();
            }
        }
    }
}
