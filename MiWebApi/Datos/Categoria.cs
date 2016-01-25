using System.Collections.Generic;

namespace MiWebApi.Datos
{
    public class Categoria
    {
        public Categoria()
        {
            Productos = new List<Producto>();
        }
        public int id { get; set; }
        public string nombre { get; set; }

        //Propiedades de navegación.
        public virtual ICollection<Producto> Productos { get; set; }

    }
}