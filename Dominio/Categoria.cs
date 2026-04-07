using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Categoria
    {
        public object descripcionC;

        public int Id { get; set; }
        public string DescripcionC { get; set; }
        public override string ToString()
        {
            return DescripcionC;
        }
    }
}
