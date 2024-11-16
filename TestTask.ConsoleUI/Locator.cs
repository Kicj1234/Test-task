using TestTask.Domain.Worker;
using TestTask.Infrastructure.InMemoryAccess.Repositories;
using TestTask.Infrastructure.InMemoryAccess;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Domain.Worker.CalculateRules;
using TestTask.Application.Boundaries.GetWorkerSalary;
using TestTask.Infrastructure.InMemoryAccess.Presenters;

namespace TestTask.ConsoleUI
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