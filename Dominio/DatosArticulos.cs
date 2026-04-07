using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DatosArticulos
    {
        public object categoria;

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public  Marcas Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }

    }
}
