using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiWebApi.Datos
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal ultimoPrecioCoste { get; set; }
        public int categoriaId { get; set; }

        //Propiedades de navegación.
        public virtual Categoria categoria { get; set; }

    }
}
