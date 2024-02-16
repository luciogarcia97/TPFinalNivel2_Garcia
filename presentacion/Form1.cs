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
        private string mensajeBusqueda = "Buscador"; // Se genero una variable global para reutilizarla
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            //Cargamos la tabla al momento de ejecutar
            cargar();
            //Frase en el buscador
            configurarMensajeBuscador();
            //Al apretar Ctrl + F quiero habilitar el menu del buscador
            tsmBuscarPorFiltros.ShortcutKeys = Keys.Control | Keys.F;
            tsmAgregarArticulo.ShortcutKeys = Keys.Control | Keys.N;
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
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void placerHolder()
        {
            pbxImagenCatalogo.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
        }

        //Busqueda Global en main
        private void btnBuscarGeneral_Click(object sender, EventArgs e)
        {
            busquedaGlobal();
        }
        private void tbxBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Si se presiona la tecla Enter, realizar la búsqueda
                busquedaGlobal();
                // Evitar que se procese la tecla Enter por defecto
                e.Handled = true;
            }
        }
        private void busquedaGlobal()
        {
            List<Articulo> listaBusqueda;
            string buscar = tbxBuscador.Text;

            if (buscar != mensajeBusqueda)
                listaBusqueda = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(buscar.ToUpper())
                || x.Descripcion.ToUpper().Contains(buscar.ToUpper())
                || x.Marca.Descripcion.ToUpper().Contains(buscar.ToUpper())
                || x.Categoria.Descripcion.ToUpper().Contains(buscar.ToUpper())
                || x.Id.ToString().ToUpper().Contains(buscar.ToUpper())
                || x.Codigo.ToString().ToUpper().Contains(buscar.ToUpper()));
            else
            {
                listaBusqueda = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaBusqueda;
            ocultarColumnas();
        }

        //Visualizacion del buscador
        private void configurarMensajeBuscador()
        {
            tbxBuscador.Text = mensajeBusqueda;
            //Cuando se entra en el buscador se limpia la busqueda
            tbxBuscador.GotFocus += (s, e) => limpiarTextoBuscador();
            //Cuando se sale del buscador se regresa el mensaje
            tbxBuscador.LostFocus += (s, e) => regresarMensajeBuscador();
        }
        private void limpiarTextoBuscador()
        {
            if (tbxBuscador.Text == mensajeBusqueda)
            {
                tbxBuscador.Text = "";
            }
        }
        private void regresarMensajeBuscador()
        {
            if (string.IsNullOrWhiteSpace(tbxBuscador.Text))
            {
                tbxBuscador.Text = mensajeBusqueda;
            }
        }

        //Busqueda por filtros
        private void tsmBuscar_Click(object sender, EventArgs e)
        {
            frmVentanaDeBusqueda buscar = new frmVentanaDeBusqueda();
            this.Hide(); //Ocultamos la ventana principal para que esta sea la nueva principal cuando se utiliza el filtro
            buscar.ShowDialog();
            this.Show(); // Volvemos a reactivar la pantalla anterior
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmVentanaDeAgregarArticulo agregar = new frmVentanaDeAgregarArticulo();
            agregar.ShowDialog();
        }
    }
}
