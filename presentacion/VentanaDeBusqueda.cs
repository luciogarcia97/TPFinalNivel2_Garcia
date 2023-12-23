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
            try
            {
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
            item.Text = string.Empty;
        }
        //Dejo los datos de los precios en funciones a parte por si el usuario tiene que modificarlos
        private void preciosMinimos(System.Windows.Forms.ComboBox item)
        {
            item.Items.Add("5000");
            item.Items.Add("10000");
            item.Items.Add("25000");
            item.Items.Add("50000");
        }
        private void preciosMaximos(System.Windows.Forms.ComboBox item)
        {
            item.Items.Add("50000");
            item.Items.Add("60000");
            item.Items.Add("80000");
            item.Items.Add("100000");
        }
    }
}
