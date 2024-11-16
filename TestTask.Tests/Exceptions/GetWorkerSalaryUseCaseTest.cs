using TestTask.Application.Cases;
using TestTask.Infrastructure.InMemoryAccess;
using TestTask.Infrastructure.InMemoryAccess.Presenters;
using TestTask.Infrastructure.InMemoryAccess.Repositories;
using TestTask.Tests.UseCases.GetAllWorkersSalary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Worker;

namespace TestTask.Tests.Exceptions
{
    public class GetWorkerSalaryUseCaseTest_OnDateException
    {
        [Test]
        public async Task GetWorkerSalaryUseCase_Worker()
        {
            try
            {
                var presenter = new GerWorkerSalaryPresenter();
                var rep = new WorkerRepository(new InMemoryContext());
                var dateOnTest = new DateTime(2015, 12, 12);
                var firstCase = new GetWorkerSalaryUseCase(presenter, new WorkerSalaryFactory(), rep);
                await firstCase.Execute(new Application.Boundaries.GetWorkerSalary.GetWorkerSalaryInput(dateOnTest, new Guid("824EF106-730C-4948-BE60-B060DA8EBA5C")));
            }
            catch (OnDateGreaterException ex)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
