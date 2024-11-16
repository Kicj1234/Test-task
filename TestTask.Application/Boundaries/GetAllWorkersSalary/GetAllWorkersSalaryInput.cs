using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Worker;

namespace TestTask.Application.Boundaries.GetAllWorkersSalary
{
    public sealed class GetAllWorkersSalaryInput
    {
        public DateTime OnDate { get; }
        public GetAllWorkersSalaryInput(DateTime onDate)
        {
            this.OnDate = onDate;
        }
    }
}
