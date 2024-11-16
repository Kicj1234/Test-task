using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Domain.Worker
{
    public class OnDateGreaterException : DomainException
    {
        public OnDateGreaterException(string message)
            : base(message)
        {
        }

        public OnDateGreaterException()

        {
        }

        public OnDateGreaterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
