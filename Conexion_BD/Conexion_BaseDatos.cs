using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Runtime.InteropServices.ComTypes;

namespace Conexion_BD
{
    public class Conexion_BaseDatos
    {
        public List<DatosArticulos> listar()
        {
            List<DatosArticulos> listar = new List<DatosArticulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true "; 
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, M.Descripcion Marca,C.Descripcion Categoria, A.IdMarca, A.IdCategoria, A.Id, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where  M.Id = A.IdMarca AND C.Id = A.IdCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    DatosArticulos aux = new DatosArticulos();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.DescripcionM = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];    //((esto me ayuda a precargar los datos para modificar))
                    aux.Categoria.DescripcionC = (string)lector["Categoria"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    if (!(lector["Precio"] is DBNull))
                        aux.Precio = Convert.ToDecimal(lector["Precio"]);

                    listar.Add(aux);

                }
                conexion.Close();
                return listar;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            //prestar atencion con las validaciones
        }
        public void agregar(DatosArticulos nuevo)
        {

            if (string.IsNullOrEmpty(nuevo.Nombre) && string.IsNullOrEmpty(nuevo.Codigo))
            {
                throw new Exception("Articulo sin guardar");
            }

            Acceso_a_Datos datos = new Acceso_a_Datos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", (object)nuevo.ImagenUrl ?? DBNull.Value);
                datos.setearParametro("@Precio", nuevo.Precio);
               
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error para agregar",ex);
            }
            finally
            {
                datos.cerrarConeccion();
            }

        }
        public void modificar(DatosArticulos modificar) 
        {
            Acceso_a_Datos datos = new Acceso_a_Datos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre , Descripcion = @descripcion ,IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagen , Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@idmarca", modificar.Marca.Id);
                datos.setearParametro("@idcategoria", modificar.Categoria.Id);
                datos.setearParametro("@imagen", modificar.ImagenUrl);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);
                datos.ejecutarAccion();

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

        public List<DatosArticulos> buscar(string categoria, string marca)
        {
            List<DatosArticulos> lista = new List<DatosArticulos>();
            Acceso_a_Datos datitos = new Acceso_a_Datos();
            try
            {
                string consulta = "SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.IdMarca, A.IdCategoria, A.Id, A.ImagenUrl, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON M.Id = A.IdMarca INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE (@categoria IS NULL OR C.Descripcion = @categoria) AND (@marca IS NULL OR M.Descripcion = @marca)";
               
                datitos.setearConsulta(consulta);
                datitos.setearParametro("@categoria", (object)categoria ?? DBNull.Value);
                datitos.setearParametro("@marca", (object)marca ?? DBNull.Value);
                datitos.ejecutarLectura();



                while (datitos.Lector.Read())
                {
                    DatosArticulos aux = new DatosArticulos();
                    aux.Id = (int)datitos.Lector["Id"];
                    aux.Codigo = (string)datitos.Lector["Codigo"];
                    aux.Nombre = (string)datitos.Lector["Nombre"];
                    aux.Descripcion = (string)datitos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datitos.Lector["IdMarca"];
                    aux.Marca.DescripcionM = (string)datitos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datitos.Lector["IdCategoria"];    
                    aux.Categoria.DescripcionC = (string)datitos.Lector["Categoria"];
                    if (!(datitos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datitos.Lector["ImagenUrl"];
                    aux.Precio = datitos.Lector["Precio"] is DBNull ? 0 : Convert.ToDecimal(datitos.Lector["Precio"]);


                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void eliminar(int id)
        {
            try
            {

                Acceso_a_Datos datos = new Acceso_a_Datos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}