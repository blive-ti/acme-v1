using Blive.Acme.App.Models;
using Blive.Acme.App.Repository;
using Blive.Acme.App.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blive.Acme.App.Controllers
{
    /// <summary>
    /// Controller used to perform CRU_D operations with Cliente entity.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        /// <summary>
        /// Repository (DI).
        /// </summary>
        public IClienteRepository ClienteRepository { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="clienteRepository"></param>
        public ClienteController(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository;
        }

        /// <summary>
        /// GET api/cliente
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json", "application/xml")]
        public ActionResult<IList<Cliente>> Get()
        {
            return Ok(ClienteRepository.GetAll());
        }

        /// <summary>
        /// GET api/cliente/000.000.000-00
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        [HttpGet("{cpf}")]
        [Produces("application/json", "application/xml")]
        public ActionResult<Cliente> Get(string cpf)
        {
            return ClienteRepository.Get(cpf);
        }

        /// <summary>
        /// POST api/cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] Cliente cliente)
        {
            ClienteRepository.Add(cliente.CPF, cliente);
            return Ok(cliente);
        }
    }
}
