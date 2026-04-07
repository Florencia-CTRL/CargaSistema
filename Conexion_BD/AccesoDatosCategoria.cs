using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Conexion_BD
{
    public class AccesoDatosCategoria
    {
        public List<Categoria> listar() 
        {
            List<Categoria> lista = new List<Categoria>();
            Acceso_a_Datos datos = new Acceso_a_Datos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS ");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) 
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.DescripcionC = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
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
