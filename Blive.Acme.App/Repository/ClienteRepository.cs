using Blive.Acme.App.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blive.Acme.App.Repository
{
    /// <summary>
    /// Represents an in memory database/repository of Clientes
    /// </summary>
    public class ClienteRepository : IClienteRepository
    {
        private IDictionary<string, Cliente> Items { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ClienteRepository()
        {
            Items = new Dictionary<string, Cliente>();
        }

        /// <summary>
        /// Adds a new item in the repository.
        /// </summary>
        /// <param name="cpf">The object to use as the key of the element to add.</param>
        /// <param name="cliente">The object to use as the value of the element to add.</param>
        public void Add(string cpf, Cliente cliente)
        {
            if (Items.ContainsKey(cpf))
            {
                Items[cpf] = cliente;
            }
            else
            {
                Items.Add(cpf, cliente);
            }
        }

        /// <summary>
        ///  Gets the value associated with the specified key.
        /// </summary>
        /// <param name="cpf">The key of the element to get.</param>
        /// <returns></returns>
        public Cliente Get(string cpf)
        {
            return Items.ContainsKey(cpf) ? Items[cpf] : default;
        }

        /// <summary>
        /// Gets an ICollection containing the values in the repository.
        /// </summary>
        /// <returns>An ICollection containing the values in the cache.</returns>
        public ICollection<Cliente> GetAll()
        {
            return Items.Values.ToList();
        }
    }
}
