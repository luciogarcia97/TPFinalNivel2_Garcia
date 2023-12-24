using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmVentanaDeAgregarArticulo : Form
    {
        private Articulo articulo = null;
        public frmVentanaDeAgregarArticulo()
        {
            InitializeComponent();
        }
        private void frmVentanaDeAgregarArticulo_Load(object sender, EventArgs e)
        {
            cargaAgregar();
        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();

            //TO DO AGREGAR ARTICULOS
            try
            {
                if(articulo == null) { articulo = new Articulo(); }

                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                

                articulo.Categoria = (Categoria)cbxAgregarCate.SelectedItem;


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargaAgregar()
        {
            modificacionComboBox(cbxAgregarMarca);
            modificacionComboBox(cbxAgregarCate);
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();

            try
            {
                cbxAgregarMarca.DataSource = marcaService.listar();
                cbxAgregarMarca.ValueMember = "Id";
                cbxAgregarMarca.DisplayMember = "Descripcion";
                cbxAgregarMarca.SelectedItem = null;

                cbxAgregarCate.DataSource = categoriaService.listar();
                cbxAgregarCate.ValueMember = "Id";
                cbxAgregarCate.DisplayMember = "Descripcion";
                cbxAgregarCate.SelectedItem = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void modificacionComboBox(System.Windows.Forms.ComboBox item)
        {
            item.DataSource = null;
            item.Items.Clear();
            item.Text = string.Empty;
        }

        private void btnAgregarNuevaMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarNuevCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
