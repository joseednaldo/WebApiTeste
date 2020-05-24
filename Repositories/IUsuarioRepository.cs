using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTeste.Models;

namespace WebApiTeste.Repositories
{
    public interface IUsuarioRepository
    {
        void Add(Usuario user);
        IEnumerable<Usuario> GetAll();
        Usuario Find(int id);
        void Remove(int id);
        void Update(Usuario user);
    }
}
