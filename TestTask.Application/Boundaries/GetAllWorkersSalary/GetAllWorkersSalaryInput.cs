using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Aspose.Domain.Worker;

namespace Aspose.Application.Boundaries.GetAllWorkersSalary
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
