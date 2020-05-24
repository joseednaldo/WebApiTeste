using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTeste.Models
{
    public class DBContexto : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DRI-EDI;Initial Catalog=WebApi;Integrated Security=True;user id=sa;password=moncerra2011;Trusted_Connection=False");

        //    }
        //}

        public DBContexto(DbContextOptions<DBContexto> options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}