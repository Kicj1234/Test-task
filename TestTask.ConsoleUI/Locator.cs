using Aspose.Domain.Worker;
using Aspose.Infrastructure.InMemoryAccess.Repositories;
using Aspose.Infrastructure.InMemoryAccess;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Domain.Worker.CalculateRules;
using Aspose.Application.Boundaries.GetWorkerSalary;
using Aspose.Infrastructure.InMemoryAccess.Presenters;

namespace Aspose.ConsoleUI
{
    public static class Locator
    {
        static Locator()
        {
            var builder = new ContainerBuilder();
            var context = new InMemoryContext();

            builder.Register((con) => new WorkerRepository(context)).As<IWorkerRepository>();
            builder.Register((con) => new WorkerSalaryFactory()).As<IWorkerSalaryFactory>();
            builder.Register((con) => new GerWorkerSalaryPresenter()).As<IOutputPort>();

            _Container = builder.Build();
        }

        private static IContainer _Container;
        public static T Resolve<T>()
        {
            return _Container.Resolve<T>();
        }
    }
}