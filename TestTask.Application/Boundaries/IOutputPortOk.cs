using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.Application.Boundaries
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
