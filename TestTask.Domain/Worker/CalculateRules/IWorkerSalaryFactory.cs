using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker.CalculateRules
{
    public interface IWorkerSalaryFactory
    {
        IWorkerCalculateRule GetCalculator(Worker worker);
    }
}
