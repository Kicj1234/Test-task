using Aspose.Application.Cases;
using Aspose.Infrastructure.InMemoryAccess;
using Aspose.Infrastructure.InMemoryAccess.Presenters;
using Aspose.Infrastructure.InMemoryAccess.Repositories;
using Aspose.Tests.UseCases.GetAllWorkersSalary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.Tests.UseCases.GetWorkerSalary
{
    public class GetWorkerSalaryUseCaseTest
    {
        [Test]
        // Emplyees
        [TestCase("824EF106-730C-4948-BE60-B060DA8EBA5C", 26500)]
        [TestCase("DB1F2867-8B6C-4EF0-9037-3957F94F2283", 25750)]
        [TestCase("46BDADF8-3358-4F07-B148-EB6D39E5F032", 25000)] 
        [TestCase("4932A1DB-6C9C-417F-BACB-AFDA123ADF75", 28000)] 
        [TestCase("CCE1DA84-8EED-4831-A987-628D4BA51545", 28000)]
        [TestCase("751F4678-6253-49B1-9605-FE54ECA95078", 26500)]
        [TestCase("3EB558D8-E098-4382-9486-2015B40B4B9A", 25750)]
        // Sales
        [TestCase("87825AC7-0F83-40CB-87D5-57FE0BA3A408", 25406.75)] 
        [TestCase("F7CF23A8-729A-49BB-B11A-E77D4D110834", 25641.97025)]
        [TestCase("D8391EB1-6A53-4515-A194-FB186072786E", 26084.0)]
        // Managers
        [TestCase("B0C88C74-6D07-4B08-81AA-737DA6B5A20D", 35388.28375)]
        [TestCase("ACA7411B-AF12-4FC4-BFA0-004F1DA2D25E", 35176.94141875)]
        [TestCase("B8D0BD29-C96E-4F75-B09B-6DC434BE4EAC", 35000)]
        public async Task GetWorkerSalaryUseCase_Worker(Guid wrkrId, decimal expSalary)
        {
            var presenter = new GerWorkerSalaryPresenter();
            var rep = new WorkerRepository(new InMemoryContext());
            var dateOnTest = new DateTime(2020, 12, 12);
            var firstCase = new GetWorkerSalaryUseCase(presenter, new WorkerSalaryFactory(), rep);
            await firstCase.Execute(new Application.Boundaries.GetWorkerSalary.GetWorkerSalaryInput(dateOnTest, wrkrId));
            Assert.IsTrue(presenter.Salary == expSalary);
        }
    }
}
