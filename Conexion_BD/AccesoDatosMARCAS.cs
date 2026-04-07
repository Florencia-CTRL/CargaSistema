using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Conexion_BD
{
    public class AccesoDatosMARCAS
    {
        
      
   
        public List<Marcas> listar()
        {
            List<Marcas> lista = new List<Marcas>();
            Acceso_a_Datos datos = new Acceso_a_Datos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.DescripcionM = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

               return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConeccion();
            }
        }
        

        
    }
    
}
