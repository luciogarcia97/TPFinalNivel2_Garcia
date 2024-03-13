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
using System.Reflection.Emit;

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
            
            //Al apretar Ctrl + N aparece el menu de crear articulo
            tsmAgregarArticulo.ShortcutKeys = Keys.Control | Keys.N;
            //Al apretar Ctrl + M aparece el menu de modificar articulo
            tsmModificarArticulo.ShortcutKeys = Keys.Control | Keys.M;
            //Al apretar Ctrl + D aparece la confirmacion de eliminar.
            tsmEliminarFisico.ShortcutKeys = Keys.Control | Keys.D;
        }
        private void cargar()
        {
            ArticuloService service = new ArticuloService();
            CategoriaService categoriaService = new CategoriaService();
            MarcaService marcaService = new MarcaService();
            modificacionComboBox(cbxCategoria);
            modificacionComboBox(cbxMarca);
            ocultarComboBoxes(cbxPrecioBase);
            ocultarComboBoxes(cbxPrecioMaximo);
            modificacionComboBox(cbxPrecioBase);
            modificacionComboBox(cbxPrecioMaximo);
            configurarMensajeBuscador();

            try
            {
                listaArticulos = service.listArticulos();
                dgvArticulos.DataSource = listaArticulos;

                // Carga de datos combobox filtro

                cbxCategoria.DataSource = categoriaService.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaService.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                //Para que no se muestren
                cbxCategoria.SelectedItem = null; 
                cbxMarca.SelectedItem = null;

                //Agregado de imagenes
                ocultarColumnas(); //Oculto la columna UrlImagen
                cargarImagen(listaArticulos[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            preciosMinimos(cbxPrecioBase);
            preciosMaximos(cbxPrecioMaximo);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            tbxBuscador.Clear();
            cargar();
        }

        //Busqueda por filtros
        
        //Con esta funcion dejamos los cbx vacios cuando cargue
        private void modificacionComboBox(System.Windows.Forms.ComboBox item)
        {
            item.DropDownStyle = ComboBoxStyle.DropDownList;
            item.DataSource = null;
            item.Items.Clear();
            item.SelectedIndex = -1; // Establece el índice de selección a -1 (ninguna selección)
        }
        //Dejo los datos de los precios en funciones a parte por si el usuario tiene que modificarlos
        private void preciosMinimos(System.Windows.Forms.ComboBox item)
        {
            item.Items.Add(50);
            item.Items.Add(20000);
            item.Items.Add(40000);
            item.Items.Add(60000);
            item.Items.Add(80000);
        }
        private void preciosMaximos(System.Windows.Forms.ComboBox item)
        {
            int precio_minimo = 100000;
            int cantidad_opciones = 4;
            for (int i = 0 ; i <= cantidad_opciones; i++)
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
                int precioBase = -1, precioMaximo = -1; //Declaro las variables, si esto funciona se pisa el valor, si falla, salta el mensaje de error.
                if (cbxPrecioBase.SelectedItem != null)
                {
                    if (int.TryParse(cbxPrecioBase.SelectedItem.ToString(), out int selectedValue))
                    {
                        precioBase = selectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo, intente nuevamente");
                    }
                }
                if (cbxPrecioMaximo.SelectedItem != null)
                {
                    if (int.TryParse(cbxPrecioMaximo.SelectedItem.ToString(), out int selectedValue))
                    {
                        precioMaximo = selectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo, intente nuevamente");
                    }
                }
                string marca = "";
                string categoria = "";
                if (!(cbxMarca.SelectedItem is null)) marca = cbxMarca.SelectedItem.ToString();
                if (!(cbxCategoria.SelectedItem is null)) categoria = cbxCategoria.SelectedItem.ToString();
                
                dgvArticulos.DataSource = service.filtrar(precioBase, precioMaximo, marca, categoria);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmVentanaDeAgregarArticulo agregar = new frmVentanaDeAgregarArticulo();
            agregar.ShowDialog();
            cargar();
        }

        private void btnEliminarFiltroMarca_Click(object sender, EventArgs e)
        {
            ocultarComboBoxes(cbxMarca);
        }

        private void btnEliminarFiltroCategoria_Click(object sender, EventArgs e)
        {
            ocultarComboBoxes(cbxCategoria);
        }
        private void ocultarComboBoxes(ComboBox items)
        {
            items.SelectedIndex = -1; // Establece el índice de selección a -1 (ninguna selección)
        }
        private void tsmModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmVentanaDeAgregarArticulo modify = new frmVentanaDeAgregarArticulo(selected);
            modify.ShowDialog();
            cargar();
        }
        private void eliminar()
        {
            ArticuloService service = new ArticuloService();
            Articulo selected = new Articulo();

            try
            {
                selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult check = MessageBox.Show("Desesar eliminar el Articulo "+ selected.Nombre + "?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    service.eliminar(selected.Id);
                    MessageBox.Show("Articulo eliminado");
                    cargar();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            Articulo selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalleProducto window = new frmDetalleProducto(selected);
            window.ShowDialog();
            // Buscar la fila que contiene el artículo con el Id especificado
            foreach (DataGridViewRow fila in dgvArticulos.Rows)
            {
                if (Convert.ToInt32(fila.Cells["Id"].Value) == selected.Id)
                {
                    fila.Selected = true; // Seleccionar la fila
                    break; // Salir del bucle una vez encontrado el registro
                }
            }
        }

        private void btnEliminarPrecioBase_Click(object sender, EventArgs e)
        {
            ocultarComboBoxes(cbxPrecioBase);
        }

        private void btnEliminarPrecioMaximo_Click(object sender, EventArgs e)
        {
            ocultarComboBoxes(cbxPrecioMaximo);
        }
    }
}