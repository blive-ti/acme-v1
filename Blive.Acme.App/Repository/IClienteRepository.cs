using Blive.Acme.App.Models;
using System.Collections.Generic;

namespace Blive.Acme.App.Repository
{
    /// <summary>
    /// Define methods to access the Cliente repository.
    /// </summary>
    public interface IClienteRepository
    {
        /// <summary>
        /// Adds a new item in the repository.
        /// </summary>
        /// <param name="cpf">The object to use as the key of the element to add.</param>
        /// <param name="cliente">The object to use as the value of the element to add.</param>
        void Add(string cpf, Cliente cliente);

        /// <summary>
        ///  Gets the value associated with the specified key.
        /// </summary>
        /// <param name="cpf">The key of the element to get.</param>
        /// <returns></returns>
        Cliente Get(string cpf);

        /// <summary>
        /// Gets an ICollection containing the values in the repository.
        /// </summary>
        /// <returns>An ICollection containing the values in the cache.</returns>
        ICollection<Cliente> GetAll();
    }
}