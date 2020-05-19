using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiculoSustitucionRCI.Dados;
using VehiculoSustitucionRCI.Dados.Modelos;

namespace WebApiTeste
{
    public class Models
    {
       
        public Models()
        {
           
        }

        public Usuario Busca()
        {
            Usuario us = new Usuario();
            us.Id = 10;
            us.Nome = "jose ednaldo";
            us.Email = "joseednaldo@gmail.com";
            return us;
        }
     
    }
}
