
using ApiPedido.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<Proveedor> proveedor { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Compra> compra { get; set; }
    }
}
