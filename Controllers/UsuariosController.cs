using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTeste.Models;
using WebApiTeste.Repositories;

namespace WebApiTeste.Controllers
{

    [Route("api/[Controller]")]

    //[Route("clientes")]
    //[ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public UsuariosController(IUsuarioRepository usuarioRepo)
        {
            //INJEÇÃO DO REPOSITORY
            _usuarioRepository = usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetaAll()
        {
            return _usuarioRepository.GetAll();
        }

        [HttpGet("{id}",Name ="GetUsuario")]
        public IActionResult GetById(int id)
        {
            var usuario = _usuarioRepository.Find(id);
            if (usuario == null)
                return NotFound();

            return new ObjectResult(usuario);
        }

    }
}