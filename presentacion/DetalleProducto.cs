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
using Negocio;

namespace presentacion
{
    public partial class frmDetalleProducto : Form
    {
        private Articulo articulo = null;
        public frmDetalleProducto()
        {
            InitializeComponent();
        }
        public frmDetalleProducto(Articulo item)
        {
            InitializeComponent();
            this.articulo = item;
        }

        private void frmDetalleProducto_Load(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();

            try
            {
                if (articulo is null)
                {
                    MessageBox.Show("entra en null");
                }
                tbxDescripcionMaestro.Text = articulo.Descripcion;
                tbxMarcaMaestro.Text = articulo.Marca.Descripcion;
                tbxCategoriaMaestro.Text = articulo.Categoria.Descripcion;
                tbxPrecioMaestro.Text = "$" + Math.Round(articulo.Precio).ToString("N2");
                cargarImagen(articulo.UrlImagen);
                tbxNombreProductoCombinado.Text = articulo.Codigo + " - " + articulo.Nombre;
                
            }
            catch (System.Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenMaestro.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenMaestro.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
