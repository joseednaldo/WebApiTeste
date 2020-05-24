using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiculoSustitucionRCI.Dados;
using WebApiTeste.Models;

namespace WebApiTeste.Controllers
{

    [Route("clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        [Route("")]
        public List<Cliente> Index()
        {
            Cliente cliente = new Cliente();
            return cliente.Todos();
        }

    }
}