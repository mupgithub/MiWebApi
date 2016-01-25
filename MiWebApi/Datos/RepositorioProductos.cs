using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWebApi.Datos
{
    public class RepositorioProductos: Repositorio<Producto>        
    {
        public RepositorioProductos(DbContext db)
            :base(db)
        {

        }
    }
}
