using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker.CalculateRules
{
    public class SalaryRuleNotFound : DomainException
    {
        public SalaryRuleNotFound(string message)
            : base(message)
        {
        }

        public SalaryRuleNotFound()

        {
        }

        public SalaryRuleNotFound(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
