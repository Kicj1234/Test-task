using TestTask.Application.Boundaries.GetWorkerSalary;
using TestTask.Domain.Worker;
using TestTask.Domain.Worker.CalculateRules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Application.Cases
{
    public class GetWorkerSalaryUseCase : IUseCase
    {
        private IOutputPort _outputPort;
        private IWorkerSalaryFactory _factory;
        private IWorkerRepository _repository;

        public GetWorkerSalaryUseCase(
                IOutputPort outputPort,
                IWorkerSalaryFactory factory,
                IWorkerRepository repository
            )
        {
            this._outputPort = outputPort;
            this._factory = factory;
            this._repository = repository;
        }

        public async Task Execute(GetWorkerSalaryInput input)
        {
            decimal result = default(decimal);
            var worker = await this._repository.GetById(input.Id);
            CalculateSalary(worker, input.OnDate, ref result);
            _outputPort.Output(new GetWorkerSalaryOutput(result));
        }

        private void CalculateSalary(Worker worker, DateTime onDate, ref decimal result)
        {
            result += _factory.GetCalculator(worker).CalculateOnDate(_factory, worker, onDate);
        }
    }
}
