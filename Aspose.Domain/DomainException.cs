using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string message)
            : base(message)
        {

        }

        public DomainException()

        {
        }

        public DomainException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
