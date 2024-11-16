using TestTask.Domain.Worker;
using TestTask.Domain.Worker.CalculateRules;
using TestTask.Domain.Worker.CalculateRules.Rules;
using TestTask.Domain.Worker.Employee;
using TestTask.Domain.Worker.Sales;

namespace TestTask.Tests.UseCases.GetAllWorkersSalary
{
    public class WorkerSalaryFactory : IWorkerSalaryFactory
    {
        public IWorkerCalculateRule GetCalculator(Worker worker)
        {
            var workType = worker.GetType().Name;

            switch(workType)
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