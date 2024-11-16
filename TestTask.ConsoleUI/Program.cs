using Aspose.Application.Boundaries.GetAllWorkersSalary;
using Aspose.Application.Boundaries.GetWorkerSalary;
using Aspose.Application.Cases;
using Aspose.Domain.Worker;
using Aspose.Domain.Worker.CalculateRules;
using Aspose.Infrastructure.InMemoryAccess;
using Aspose.Infrastructure.InMemoryAccess.Presenters;
using System;
using System.Threading.Tasks;

namespace Aspose.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = Locator.Resolve<IWorkerRepository>();
            Console.WriteLine("Salaries of different types of workers by worker on date");
            foreach (var worker in repository.GetAll().Result)
            {
                decimal salary = CalculateSalaryForWorker(worker.Id).Result;
                Console.WriteLine($"Name: {worker.Name} Salary: {salary}"  );
            }
            var allSalariesSum = CalculateSalaryForAllWorkes().Result;
            Console.WriteLine($"AllSalaries of all workers: {allSalariesSum}");
            Console.Read();
        }

        public static async Task<decimal> CalculateSalaryForWorker(Guid wrkrId)
        {
            var presenter = new GerWorkerSalaryPresenter();
            var salaryCase = new GetWorkerSalaryUseCase(
                presenter,
                Locator.Resolve<IWorkerSalaryFactory>(), 
                Locator.Resolve<IWorkerRepository>());
            await salaryCase.Execute(new GetWorkerSalaryInput(new DateTime(2020, 12, 12), wrkrId));
            return presenter.Salary;
        }

        public static async Task<decimal> CalculateSalaryForAllWorkes()
        {
            var presenter = new GetAllWorkersSalaryPresenter();
            var salaryAllCase = new GetAllWorkersSalaryUseCase(
                presenter, 
                Locator.Resolve<IWorkerSalaryFactory>(),
                Locator.Resolve<IWorkerRepository>());
            await salaryAllCase.Execute(new GetAllWorkersSalaryInput(new DateTime(2020, 12, 12)));
            return presenter.AllSalariesSum;
        }
    }
}
