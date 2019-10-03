using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blive.Acme.App.Utils
{
    /// <summary>
    /// Checks if the CPF is valid.
    /// </summary>
    public abstract class CpfValidator
    {
        /// <summary>
        /// Checks if the CPF is valid.
        /// </summary>
        /// <param name="cpf">The CPF to be validated.</param>
        /// <returns>True if is valid, otherwise false.</returns>
        public abstract bool IsValid(string cpf);
    }
}
