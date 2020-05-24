using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTeste.Models;

namespace WebApiTeste.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly DBContexto _contexto;
        public UsuarioRepository(DBContexto contexto)
        {
            //injeção de depencencia  do contexto
            _contexto = contexto;
        }
        public void Add(Usuario user)
        {
            _contexto.Usuarios.Add(user);
            _contexto.SaveChanges();
        }

        public Usuario Find(int id)
        {
            return _contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuarios.ToList();
        }

        public void Remove(int id)
        {
            var usuario = _contexto.Usuarios.First(u => u.UsuarioId == id);
            _contexto.Usuarios.Remove(usuario);
            _contexto.SaveChanges();
        }

        public void Update(Usuario user)
        {
            _contexto.Usuarios.Update(user);
            _contexto.SaveChanges();
        }
    }
}
