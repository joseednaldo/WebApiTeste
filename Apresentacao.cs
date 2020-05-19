using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTeste
{
    public class Apresentacao
    {
        private List<string>rotas { get; set; }

        private List<string> Rotas { get { return this.rotas; }  }
        private string Mensagem { get { return "Seja bem vindo a nossa API"; } }

        public Apresentacao()
        {
            
            rotas = new List<string>();
            rotas.Add("/clientes");

        }

    }

}
