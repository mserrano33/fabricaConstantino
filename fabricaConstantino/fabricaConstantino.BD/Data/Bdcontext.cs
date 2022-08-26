using Microsoft.EntityFrameworkCore;
using fabricaConstantino.BD.Data.Entidad;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaConstantino.BD.Data
{
    public class Bdcontext :DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<DetalledeOrden> DetalledeOrdenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<CategoriadeProducto> CategoriadeProductos { get; set; }

        
        public Bdcontext(DbContextOptions options) : base(options)
        {

        }
    }
}
