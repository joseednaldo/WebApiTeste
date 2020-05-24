using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTeste.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        private static DBContexto db  = new DBContexto();
        public Cliente()
        {
           
        }

        public Cliente Salva()
        {
            db.Clientes.Add(this);
            db.SaveChanges();
            return this;
        }

        public List<Cliente> Todos()
        {
            return db.Clientes.ToList();
        }


        public int ClienteId { get; set; }

        [StringLength(100)]
        public string nome { get; set; }



    }
}
