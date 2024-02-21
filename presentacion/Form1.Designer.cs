using System.Drawing;

namespace presentacion
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenCatalogo = new System.Windows.Forms.PictureBox();
            this.mnsBarradeAcciones = new System.Windows.Forms.MenuStrip();
            this.tsmArticulosWork = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarFisico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarLogico = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarGeneral = new System.Windows.Forms.Button();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxPrecioMaximo = new System.Windows.Forms.ComboBox();
            this.cbxPrecioBase = new System.Windows.Forms.ComboBox();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblOpcionales = new System.Windows.Forms.Label();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.btnEliminarFiltroMarca = new System.Windows.Forms.Button();
            this.btnEliminarFiltroCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCatalogo)).BeginInit();
            this.mnsBarradeAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 70);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(643, 331);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxImagenCatalogo
            // 
            this.pbxImagenCatalogo.Location = new System.Drawing.Point(761, 70);
            this.pbxImagenCatalogo.Name = "pbxImagenCatalogo";
            this.pbxImagenCatalogo.Size = new System.Drawing.Size(234, 331);
            this.pbxImagenCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCatalogo.TabIndex = 1;
            this.pbxImagenCatalogo.TabStop = false;
            // 
            // mnsBarradeAcciones
            // 
            this.mnsBarradeAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArticulosWork});
            this.mnsBarradeAcciones.Location = new System.Drawing.Point(0, 0);
            this.mnsBarradeAcciones.Name = "mnsBarradeAcciones";
            this.mnsBarradeAcciones.Size = new System.Drawing.Size(1038, 24);
            this.mnsBarradeAcciones.TabIndex = 2;
            this.mnsBarradeAcciones.Text = "menuStrip1";
            // 
            // tsmArticulosWork
            // 
            this.tsmArticulosWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarArticulo,
            this.tsmModificarArticulo,
            this.tsmEliminarArticulo});
            this.tsmArticulosWork.Name = "tsmArticulosWork";
            this.tsmArticulosWork.Size = new System.Drawing.Size(66, 20);
            this.tsmArticulosWork.Text = "Articulos";
            // 
            // tsmAgregarArticulo
            // 
            this.tsmAgregarArticulo.Name = "tsmAgregarArticulo";
            this.tsmAgregarArticulo.Size = new System.Drawing.Size(125, 22);
            this.tsmAgregarArticulo.Text = "Agregar";
            this.tsmAgregarArticulo.Click += new System.EventHandler(this.tsmAgregarArticulo_Click);
            // 
            // tsmModificarArticulo
            // 
            this.tsmModificarArticulo.Name = "tsmModificarArticulo";
            this.tsmModificarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarArticulo.Text = "Modificar";
            this.tsmModificarArticulo.Click += new System.EventHandler(this.tsmModificarArticulo_Click);
            // 
            // tsmEliminarArticulo
            // 
            this.tsmEliminarArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarFisico,
            this.tsmEliminarLogico});
            this.tsmEliminarArticulo.Name = "tsmEliminarArticulo";
            this.tsmEliminarArticulo.Size = new System.Drawing.Size(125, 22);
            this.tsmEliminarArticulo.Text = "Eliminar";
            // 
            // tsmEliminarFisico
            // 
            this.tsmEliminarFisico.Name = "tsmEliminarFisico";
            this.tsmEliminarFisico.Size = new System.Drawing.Size(110, 22);
            this.tsmEliminarFisico.Text = "Fisico";
            // 
            // tsmEliminarLogico
            // 
            this.tsmEliminarLogico.Name = "tsmEliminarLogico";
            this.tsmEliminarLogico.Size = new System.Drawing.Size(110, 22);
            this.tsmEliminarLogico.Text = "Logico";
            // 
            // btnBuscarGeneral
            // 
            this.btnBuscarGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarGeneral.Image")));
            this.btnBuscarGeneral.Location = new System.Drawing.Point(218, 44);
            this.btnBuscarGeneral.Name = "btnBuscarGeneral";
            this.btnBuscarGeneral.Size = new System.Drawing.Size(19, 20);
            this.btnBuscarGeneral.TabIndex = 5;
            this.btnBuscarGeneral.UseVisualStyleBackColor = true;
            this.btnBuscarGeneral.Click += new System.EventHandler(this.btnBuscarGeneral_Click);
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.BackColor = System.Drawing.Color.White;
            this.tbxBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscador.Location = new System.Drawing.Point(37, 44);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(175, 20);
            this.tbxBuscador.TabIndex = 4;
            this.tbxBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBuscador_KeyPress);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(376, 495);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(144, 21);
            this.cbxCategoria.TabIndex = 18;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(580, 493);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarFiltro.TabIndex = 17;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(315, 498);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(376, 463);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(144, 21);
            this.cbxMarca.TabIndex = 15;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(330, 466);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // cbxPrecioMaximo
            // 
            this.cbxPrecioMaximo.FormattingEnabled = true;
            this.cbxPrecioMaximo.Location = new System.Drawing.Point(93, 495);
            this.cbxPrecioMaximo.Name = "cbxPrecioMaximo";
            this.cbxPrecioMaximo.Size = new System.Drawing.Size(144, 21);
            this.cbxPrecioMaximo.TabIndex = 13;
            // 
            // cbxPrecioBase
            // 
            this.cbxPrecioBase.FormattingEnabled = true;
            this.cbxPrecioBase.Location = new System.Drawing.Point(93, 463);
            this.cbxPrecioBase.Name = "cbxPrecioBase";
            this.cbxPrecioBase.Size = new System.Drawing.Size(144, 21);
            this.cbxPrecioBase.TabIndex = 12;
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Location = new System.Drawing.Point(9, 498);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioMaximo.TabIndex = 11;
            this.lblPrecioMaximo.Text = "Precio maximo:";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(21, 466);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(66, 13);
            this.lblPrecioBase.TabIndex = 10;
            this.lblPrecioBase.Text = "Precio base:";
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 44);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(19, 20);
            this.btnHome.TabIndex = 19;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblOpcionales
            // 
            this.lblOpcionales.AutoSize = true;
            this.lblOpcionales.Location = new System.Drawing.Point(405, 441);
            this.lblOpcionales.Name = "lblOpcionales";
            this.lblOpcionales.Size = new System.Drawing.Size(63, 13);
            this.lblOpcionales.TabIndex = 20;
            this.lblOpcionales.Text = "Opcionales:";
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTituloBusqueda.Location = new System.Drawing.Point(8, 413);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(277, 22);
            this.lblTituloBusqueda.TabIndex = 21;
            this.lblTituloBusqueda.Text = "Busqueda por rango de precios";
            // 
            // btnEliminarFiltroMarca
            // 
            this.btnEliminarFiltroMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFiltroMarca.Image")));
            this.btnEliminarFiltroMarca.Location = new System.Drawing.Point(526, 463);
            this.btnEliminarFiltroMarca.Name = "btnEliminarFiltroMarca";
            this.btnEliminarFiltroMarca.Size = new System.Drawing.Size(20, 21);
            this.btnEliminarFiltroMarca.TabIndex = 22;
            this.btnEliminarFiltroMarca.UseVisualStyleBackColor = true;
            this.btnEliminarFiltroMarca.Click += new System.EventHandler(this.btnEliminarFiltroMarca_Click);
            // 
            // btnEliminarFiltroCategoria
            // 
            this.btnEliminarFiltroCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarFiltroCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFiltroCategoria.Image")));
            this.btnEliminarFiltroCategoria.Location = new System.Drawing.Point(526, 495);
            this.btnEliminarFiltroCategoria.Name = "btnEliminarFiltroCategoria";
            this.btnEliminarFiltroCategoria.Size = new System.Drawing.Size(20, 21);
            this.btnEliminarFiltroCategoria.TabIndex = 23;
            this.btnEliminarFiltroCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarFiltroCategoria.Click += new System.EventHandler(this.btnEliminarFiltroCategoria_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 520);
            this.Controls.Add(this.btnEliminarFiltroCategoria);
            this.Controls.Add(this.btnEliminarFiltroMarca);
            this.Controls.Add(this.lblTituloBusqueda);
            this.Controls.Add(this.lblOpcionales);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxPrecioMaximo);
            this.Controls.Add(this.cbxPrecioBase);
            this.Controls.Add(this.lblPrecioMaximo);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.btnBuscarGeneral);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.pbxImagenCatalogo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.mnsBarradeAcciones);
            this.MainMenuStrip = this.mnsBarradeAcciones;
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCatalogo)).EndInit();
            this.mnsBarradeAcciones.ResumeLayout(false);
            this.mnsBarradeAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxImagenCatalogo;
        private System.Windows.Forms.MenuStrip mnsBarradeAcciones;
        private System.Windows.Forms.ToolStripMenuItem tsmArticulosWork;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarFisico;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarLogico;
        private System.Windows.Forms.Button btnBuscarGeneral;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxPrecioMaximo;
        private System.Windows.Forms.ComboBox cbxPrecioBase;
        private System.Windows.Forms.Label lblPrecioMaximo;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblOpcionales;
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.Button btnEliminarFiltroMarca;
        private System.Windows.Forms.Button btnEliminarFiltroCategoria;
    }
}

