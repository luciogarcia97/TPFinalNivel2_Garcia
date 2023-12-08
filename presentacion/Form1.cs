using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace presentacion
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            //Cargamos la tabla al momento de ejecutar
            cargar();

        }
        private void cargar()
        {
            ArticuloService service = new ArticuloService();
            try
            {
                listaArticulos = service.listArticulos();
                dgvArticulos.DataSource = listaArticulos;
                //Agregado de imagenes
                ocultarColumnas(); //Oculto la columna UrlImagen
                cargarImagen(listaArticulos[0].UrlImagen);
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
                if (!string.IsNullOrEmpty(imagen)) //Corroboro que no sea null para que no rompa.
                    pbxImagenCatalogo.Load(imagen);
                else
                    placerHolder();

            }
            catch (Exception)
            {
                placerHolder();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo selectedArticle = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(selectedArticle.UrlImagen);
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
        }
        private void placerHolder()
        {
            pbxImagenCatalogo.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
        }
    }
}
