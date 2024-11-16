using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker
{
    /// <summary>
    ///     Base class for any employee entity
    /// </summary>
    public abstract class Worker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime EmploymentDate { get; set; }
        public decimal Salary { get; set; }
        public IEnumerable<Worker> Children { get; set; }
    }
}
