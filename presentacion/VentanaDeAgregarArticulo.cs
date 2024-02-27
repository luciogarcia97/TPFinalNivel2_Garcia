using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        public frmVentanaDeAgregarArticulo(Articulo item)
        {
            InitializeComponent();
            this.articulo = item;
            Text = "Modificar Articulo";
            btnAceptar.Text = "Modificar";
        }
        private void frmVentanaDeAgregarArticulo_Load(object sender, EventArgs e)
        {
            cargaAgregar();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();

            try
            {
                if(articulo == null) { articulo = new Articulo(); }
                
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Marca = (Marca)cbxAgregarMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxAgregarCate.SelectedItem;
                articulo.UrlImagen = tbxImagenUrl.Text;
                articulo.Precio = Convert.ToDecimal(tbxPrecio.Text);

                if(articulo.Id != 0)
                {
                articuloService.modificarArticulo(articulo);
                MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                articuloService.agregarArticulo(articulo);
                MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargaAgregar()
        {
            
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();

            try
            {
                modificacionComboBox(cbxAgregarMarca);
                modificacionComboBox(cbxAgregarCate);
                cbxAgregarMarca.DataSource = marcaService.listar();
                cbxAgregarMarca.ValueMember = "Id";
                cbxAgregarMarca.DisplayMember = "Descripcion";
                cbxAgregarMarca.SelectedItem = null;

                cbxAgregarCate.DataSource = categoriaService.listar();
                cbxAgregarCate.ValueMember = "Id";
                cbxAgregarCate.DisplayMember = "Descripcion";
                cbxAgregarCate.SelectedItem = null;

                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    cbxAgregarMarca.SelectedValue = articulo.Marca.Id;
                    cbxAgregarCate.SelectedValue = articulo.Categoria.Id;
                    tbxImagenUrl.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    tbxPrecio.Text = articulo.Precio.ToString();
                }

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
            MarcaService marcaService = new MarcaService(); 
            List<Marca> listaMarcas = new List<Marca>();
            
            listaMarcas = marcaService.listar();
            string nuevaMarca = cbxAgregarMarca.Text;
            if(!validacionesAgregar(nuevaMarca))
            {
                return;
            }
            if(!validacionMarcaNueva(nuevaMarca,listaMarcas))
            {
                return;
            }
            try
            {
                Marca marca = new Marca();
                marca.Descripcion = nuevaMarca;

                marcaService.agregar(marca);
                MessageBox.Show("Agregado exitosamente");
                cargaAgregar();

            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        private void btnAgregarNuevCategoria_Click(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService(); 
            List<Categoria> listaCategoria = new List<Categoria>();
            
            listaCategoria = categoriaService.listar();
            string nuevaCategoria = cbxAgregarCate.Text;
            if(!validacionesAgregar(nuevaCategoria))
            {
                return;
            }
            if(!validacionCategoriaNueva(nuevaCategoria,listaCategoria))
            {
                return;
            }
            try
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = nuevaCategoria;

                categoriaService.agregar(categoria);
                MessageBox.Show("Agregado exitosamente");
                cargaAgregar();

            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenNuevo.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenNuevo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(tbxImagenUrl.Text);
        }
        private bool validacionMarcaNueva(string item, List<Marca> lista)
        {
            var itemEncontrado = lista.Find(x => x.Descripcion.Equals(item.ToUpper(), StringComparison.OrdinalIgnoreCase));
            
            if (itemEncontrado != null)
            {
                MessageBox.Show($"El item ingresado ya se encuentra: {itemEncontrado.Descripcion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool validacionCategoriaNueva(string item, List<Categoria> lista)
        {
            var itemEncontrado = lista.Find(x => x.Descripcion.Equals(item.ToUpper(), StringComparison.OrdinalIgnoreCase));
            
            if (itemEncontrado != null)
            {
                MessageBox.Show($"El item ingresado ya se encuentra: {itemEncontrado.Descripcion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool validacionesAgregar(string item)
        {
            bool aux = true;
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("El campo se encuentra vacio, no se agrego un nuevo item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aux = false;
                return aux;
            }
            return aux;
        }
        
    }
}
