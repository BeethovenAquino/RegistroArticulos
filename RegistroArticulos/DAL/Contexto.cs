using RegistroArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroArticulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public Contexto() : base("ConStr") { }

    }
}
