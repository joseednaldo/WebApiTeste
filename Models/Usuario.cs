using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTeste.Models
{
    public class Usuario
    {

        public int UsuarioId { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string Senha { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
    }
}
