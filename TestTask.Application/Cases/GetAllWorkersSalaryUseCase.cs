using TestTask.Application.Boundaries.GetAllWorkersSalary;
using TestTask.Domain.Worker;
using TestTask.Domain.Worker.CalculateRules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Application.Cases
{
    public class GetAllWorkersSalaryUseCase : IUseCase
    {
        private IOutputPort _outputPort;
        private IWorkerSalaryFactory _factory;
        private IWorkerRepository _repository;

        public GetAllWorkersSalaryUseCase(
            IOutputPort outputPort,
            IWorkerSalaryFactory factory,
            IWorkerRepository repository
            )
        {
            this._outputPort = outputPort;
            this._factory = factory;
            this._repository = repository;
        }

        public async Task Execute(GetAllWorkersSalaryInput input)
        {
            decimal result = default;
            var workers = this._repository.GetAll().Result;
            CalculateSalary(workers, input.OnDate, ref result);
            _outputPort.Output(new GetAllWorkersSalaryOutput(result));
        }   

        private void CalculateSalary(IEnumerable<Worker> workers, DateTime onDate,ref decimal result)
        {
            foreach (var worker in workers)
            {
                try
                {
                    result += _factory.GetCalculator(worker).CalculateOnDate(_factory, worker, onDate);
                }
                catch(OnDateGreaterException e)
                {
                    result += 0;
                    continue;
                }
            }
        }
    }
}
