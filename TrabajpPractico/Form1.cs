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
    public partial class Form1 : Form
    {
        private List<DatosArticulos> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

            desplegableCategoria.DataSource = listaArticulos
                .Select(a => a.Categoria.DescripcionC)
                .Distinct()
                .ToList();


            desplegablaMarca.DataSource = listaArticulos
             .Select(a => a.Marca.DescripcionM)
             .Distinct()
             .ToList();

            desplegableCategoria.SelectedIndex = -1;
            desplegablaMarca.SelectedIndex = -1;

        }



        private void dataGridArticulos_SelectionChanged(object sender, EventArgs e)
        {
            DatosArticulos seleccionado =(DatosArticulos)dataGridArticulos.CurrentRow.DataBoundItem;

            if(dataGridArticulos.CurrentRow != null)
            {
                
                cargarImagen(seleccionado.ImagenUrl);

                ValorNombre.Text = seleccionado.Nombre;
                ValorMarca.Text = seleccionado.Marca.DescripcionM;
                ValorDescripcion.Text = seleccionado.Descripcion;
                ValorPrecio.Text = seleccionado.Precio.ToString("c");
                
            }
           
        }

        private void cargar()
        {
            Conexion_BaseDatos articulos = new Conexion_BaseDatos();
            try
            {
                listaArticulos = articulos.listar();
                dataGridArticulos.DataSource = listaArticulos;
                dataGridArticulos.Columns["ImagenUrl"].Visible = false;  
                dataGridArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cargarImagen(string imagen)     
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                {
                    CajaDeImagen.LoadAsync(imagen); 
                }
                else
                {
                   
                    CajaDeImagen.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/2048px-Imagen_no_disponible.svg.png");
                }
            }
            catch
            {
               
                CajaDeImagen.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/2048px-Imagen_no_disponible.svg.png");
            }


        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Carga_Articulos agregar = new Carga_Articulos();
            agregar.ShowDialog();
            cargar();
           
        }

        

        private void botonModificar_Click(object sender, EventArgs e)
        {
            DatosArticulos seleccionado;
            seleccionado = (DatosArticulos)dataGridArticulos.CurrentRow.DataBoundItem;

            Carga_Articulos modificar = new Carga_Articulos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Conexion_BaseDatos basedatos = new Conexion_BaseDatos();
            DatosArticulos seleccionado;
            try
            {
                seleccionado = (DatosArticulos)dataGridArticulos.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show($"¿estas seguro de eliminar el articulo '{seleccionado.Nombre}'?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              
                if(resultado == DialogResult.Yes)
                {
                    basedatos.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Conexion_BaseDatos datos = new Conexion_BaseDatos();
            try
            {
                if(desplegableCategoria.SelectedItem == null && desplegablaMarca.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione al menos un item para una mejor busqueda");
                    return;
                }
                string categoria = desplegableCategoria.SelectedItem?.ToString();
                string marca =  desplegablaMarca.SelectedItem?.ToString();
                dataGridArticulos.DataSource = datos.buscar(categoria, marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BotonRESTABLECER_Click(object sender, EventArgs e)
        {
            desplegableCategoria.SelectedIndex = -1;
            desplegablaMarca.SelectedIndex = -1;
            dataGridArticulos.DataSource = listaArticulos;
        }
    }
}
