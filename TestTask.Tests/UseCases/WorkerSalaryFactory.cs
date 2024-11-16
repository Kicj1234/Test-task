using Aspose.Domain.Worker;
using Aspose.Domain.Worker.CalculateRules;
using Aspose.Domain.Worker.CalculateRules.Rules;
using Aspose.Domain.Worker.Employee;
using Aspose.Domain.Worker.Sales;

namespace Aspose.Tests.UseCases.GetAllWorkersSalary
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