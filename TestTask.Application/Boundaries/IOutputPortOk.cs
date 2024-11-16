using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Application.Boundaries
{
    public interface IOutputPortOk<in TUseCaseOutput>
    {
        /// <summary>
        ///     Writes to the Output.
        /// </summary>
        /// <param name="output">The Output Port Message.</param>
        void Output(TUseCaseOutput output);
    }
}
