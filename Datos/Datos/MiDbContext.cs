using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWebApi.Datos
{
    public class MiDbContext: DbContext
    {
        public MiDbContext()
            : base("name=MiWebApiContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<Compra> Compras { get; set; }
        //public DbSet<DetalleCompra> DetalleCompras { get; set; }
        //public DbSet<Proveedor> Proveedores { get; set; }
    }
}
