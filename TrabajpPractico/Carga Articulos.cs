using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Conexion_BD;


namespace TrabajpPractico
{
    public partial class Carga_Articulos : Form
    {
        private DatosArticulos articulos = null;
        public Carga_Articulos()
        {
            InitializeComponent();
        }
        public Carga_Articulos(DatosArticulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Articulo";  
        }


        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

            Conexion_BaseDatos llamador = new Conexion_BaseDatos();
            try
            {
                if (articulos == null)
                    articulos = new DatosArticulos();
                if (string.IsNullOrWhiteSpace(CajaparaNombre.Text) && string.IsNullOrWhiteSpace(CajaparaCodigo.Text))
                {
                    MessageBox.Show("ARTICULO VACIO");
                    return;
                }

                if (string.IsNullOrEmpty(CajadePrecio.Text))
                {
                    articulos.Precio = 0;
                }
                else
                {
                    if (!soloNumeros(CajadePrecio.Text))
                    {
                        MessageBox.Show("solo numeros");
                        CajadePrecio.Focus();
                        return;
                    }
                    articulos.Precio = decimal.Parse(CajadePrecio.Text);
                }
                    articulos.Nombre = CajaparaNombre.Text;
                articulos.Codigo = CajaparaCodigo.Text;
                articulos.Descripcion = CajadeDescripcion.Text;
                articulos.Marca = (Marcas)desplegableMarca.SelectedItem;
                articulos.Categoria = (Categoria)desplegableCategoria.SelectedItem;
                articulos.ImagenUrl = CajaInsertarURL.Text;  
                
                
                if (articulos.Id != 0)
                {
                    llamador.modificar(articulos);
                    MessageBox.Show("Modificado correctamente");

                }
                else
                {
                    llamador.agregar(articulos);
                    MessageBox.Show("Se agrego correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

         private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!char.IsDigit(caracter) && caracter != ',' && caracter != '.')
                    return false;
            }
            return true;
        }

                               //ACA EN CARGA ARTICULOS HAY ERRORES CON LOS DESPLEGABLES REVISAR BIEN(EL OTRO CODIGO ESTA EN EL BLOCK DE NOTAS)
        private void Carga_Articulos_Load(object sender, EventArgs e)  
        {
            AccesoDatosMARCAS muestraMarcas = new AccesoDatosMARCAS();
            AccesoDatosCategoria muestraCategoria = new AccesoDatosCategoria();
            try
            {
                desplegableCategoria.ValueMember = "Id"; 
                desplegableCategoria.DisplayMember = "Descripcion"; 
                desplegableCategoria.DataSource = muestraCategoria.listar();

                desplegableMarca.ValueMember = "id";
                desplegableMarca.DisplayMember = "descripcion";
                desplegableMarca.DataSource = muestraMarcas.listar();

                desplegableCategoria.SelectedIndex = -1;
                desplegableMarca.SelectedIndex = -1;

                if( articulos != null)       
                {
                    CajaparaCodigo.Text = articulos.Codigo;
                    CajaparaNombre.Text = articulos.Nombre;
                    CajadeDescripcion.Text = articulos.Descripcion;
                    desplegableMarca.SelectedValue = articulos.Marca.Id;
                    desplegableCategoria.SelectedValue = articulos.Categoria.Id;
                    CajaInsertarURL.Text = articulos.ImagenUrl;
                    cargarImagen(articulos.ImagenUrl);
                    CajadePrecio.Text = articulos.Precio.ToString("0.00");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CajaInsertarURL_leave(object sender, EventArgs e)
        {
            cargarImagen(CajaInsertarURL.Text);
        }

        private void cargarImagen(string imagen)  
        {

            try
            {
                if (!string.IsNullOrEmpty(imagen))
                {
                    imagenParaSUBIR.Load(imagen);
                }
                else
                {
                    imagenParaSUBIR.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/2048px-Imagen_no_disponible.svg.png");
                }
            }
            catch 
            {
                imagenParaSUBIR.Image = imagenParaSUBIR.ErrorImage;
            }

            


        }

        private void imagenParaSUBIR_Click(object sender, EventArgs e)
        {

        }

        private void CajaInsertarURL_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(CajaInsertarURL.Text);
        }

        private void CajadePrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
