using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace presentacion
{
    public partial class frmVentanaDeBusqueda : Form
    {
        List<Articulo> listaArticulos;
        public frmVentanaDeBusqueda()
        {
            InitializeComponent();
        }

        private void frmVentanaDeBusqueda_Load(object sender, EventArgs e)
        {
            cargaCampos();
        }
        //Unifico toda la carga de los cbx
        private void cargaCampos()
        {
            modificacionComboBox(cbxCategoria);
            modificacionComboBox(cbxMarca);
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();
            ArticuloService articuloService = new ArticuloService();
            try
            {
                listaArticulos = articuloService.listArticulos();
                dgvArticulosFiltrados.DataSource = listaArticulos;
                //Agregado de imagenes
                ocultarColumnas(); //Oculto la columna UrlImagen
                cargarImagen(listaArticulos[0].UrlImagen);

                cbxCategoria.DataSource = categoriaService.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                cbxCategoria.SelectedItem = null;

                cbxMarca.DataSource = marcaService.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                cbxMarca.SelectedItem = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            preciosMinimos(cbxPrecioBase);
            preciosMaximos(cbxPrecioMaximo);
        }
        //Con esta funcion dejamos los cbx vacios cuando cargue
        private void modificacionComboBox(System.Windows.Forms.ComboBox item)
        {
            item.DataSource = null;
            item.Items.Clear();
            item.SelectedIndex = -1; // Establece el índice de selección a -1 (ninguna selección)
        }
        //Dejo los datos de los precios en funciones a parte por si el usuario tiene que modificarlos
        private void preciosMinimos(System.Windows.Forms.ComboBox item)
        {
            int precio_minimo = 5000;
            int cantidad_opciones = 4;
            for (int i = 0 ; i < cantidad_opciones +1; i++)
            {
                item.Items.Add(precio_minimo + (5000) * i);
            }
        }
        private void preciosMaximos(System.Windows.Forms.ComboBox item)
        {
            int precio_minimo = 100000;
            int cantidad_opciones = 4;
            for (int i = 0 ; i < cantidad_opciones +1; i++)
            {
                precio_minimo = (precio_minimo + (5000) * i);
                item.Items.Add(precio_minimo);
            }
        }
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            ArticuloService service = new ArticuloService();
            

            try
            {
                int precioBase = cbxPrecioBase.SelectedIndex;
                int precioMaximo = (int)cbxPrecioMaximo.SelectedIndex;
                string marca = "";
                if (cbxMarca.SelectedItem != null) marca = cbxMarca.SelectedItem.ToString();
                string categoria = "";
                if (cbxCategoria.SelectedItem != null) categoria = cbxCategoria.SelectedItem.ToString();
                
                dgvArticulosFiltrados.DataSource = service.filtrar(precioBase, precioMaximo, marca, categoria);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void ocultarColumnas()
        {
            dgvArticulosFiltrados.Columns["UrlImagen"].Visible = false;
            dgvArticulosFiltrados.Columns["Id"].Visible = false;
        }
                private void cargarImagen(string imagen)
        {
            try
            {
            if (!string.IsNullOrEmpty(imagen)) //Corroboro que no sea null para que no rompa.
                pbxImagenCatalogoFiltrado.Load(imagen);
            else
                placerHolder();
            }
            catch (Exception)
            {
                placerHolder();
            }
        }
        private void placerHolder()
        {
            pbxImagenCatalogoFiltrado.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
        }

    }
}
