using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Application.Boundaries.GetWorkerSalary
{
    public class GetWorkerSalaryInput
    {
        public DateTime OnDate { get; }
        public Guid Id { get; }

        public GetWorkerSalaryInput(DateTime onDate, Guid id)
        {
            this.OnDate = onDate;
            this.Id = id;
        }
    }
}
