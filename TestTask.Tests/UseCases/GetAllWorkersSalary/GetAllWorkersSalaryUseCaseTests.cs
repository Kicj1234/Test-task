using TestTask.Application.Cases;
using TestTask.Domain.Worker.Manager;
using TestTask.Infrastructure.InMemoryAccess;
using TestTask.Infrastructure.InMemoryAccess.Presenters;
using TestTask.Infrastructure.InMemoryAccess.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Tests.UseCases.GetAllWorkersSalary
{
    public class GetAllWorkersSalaryUseCaseTests
    {
        [Test]
        [TestCase(368197.94541875)]

        public async Task GetAllWorkersSalaryUseCase_Manager(decimal AllSalary)
        {
            var presenter = new GetAllWorkersSalaryPresenter();
            var rep = new WorkerRepository(new InMemoryContext());
            var firstCase = new GetAllWorkersSalaryUseCase(presenter, new WorkerSalaryFactory(), rep);
            var dateOnTest = new DateTime(2020, 12, 12);
            await firstCase.Execute(new Application.Boundaries.GetAllWorkersSalary.GetAllWorkersSalaryInput(dateOnTest));
            Assert.IsTrue(presenter.AllSalariesSum == AllSalary);
        }
    }
}