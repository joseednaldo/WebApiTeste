using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiculoSustitucionRCI.Dados;

namespace WebApiTeste.Controllers
{

    [Route("clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        [Route("")]
        public Usuario Index()
        {
            Usuario us = new Usuario();
            us.Id = 10;
            us.Nome = "jose ednaldo";
            us.Email = "joseednaldo@gmail.com";
            us.testeA = true;
            return us;

        }

    }
}