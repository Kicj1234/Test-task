using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Domain.Worker
{
    /// <summary>
    ///     Worker not found expcetion
    /// </summary>
    public class WorkerNotFoundException : DomainException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkerNotFoundException" /> class.
        /// </summary>
        /// <param name="message">Message.</param>
        internal WorkerNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// </summary>
        public WorkerNotFoundException()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner Exception.</param>
        public WorkerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
