namespace presentacion
{
    partial class frmVentanaDeBusqueda
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
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.cbxPrecioBase = new System.Windows.Forms.ComboBox();
            this.cbxPrecioMaximo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pbxImagenCatalogoFiltrado = new System.Windows.Forms.PictureBox();
            this.dgvArticulosFiltrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCatalogoFiltrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosFiltrados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(66, 402);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(66, 13);
            this.lblPrecioBase.TabIndex = 0;
            this.lblPrecioBase.Text = "Precio base:";
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Location = new System.Drawing.Point(54, 436);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioMaximo.TabIndex = 1;
            this.lblPrecioMaximo.Text = "Precio maximo:";
            // 
            // cbxPrecioBase
            // 
            this.cbxPrecioBase.FormattingEnabled = true;
            this.cbxPrecioBase.Location = new System.Drawing.Point(138, 399);
            this.cbxPrecioBase.Name = "cbxPrecioBase";
            this.cbxPrecioBase.Size = new System.Drawing.Size(144, 21);
            this.cbxPrecioBase.TabIndex = 2;
            // 
            // cbxPrecioMaximo
            // 
            this.cbxPrecioMaximo.FormattingEnabled = true;
            this.cbxPrecioMaximo.Location = new System.Drawing.Point(138, 433);
            this.cbxPrecioMaximo.Name = "cbxPrecioMaximo";
            this.cbxPrecioMaximo.Size = new System.Drawing.Size(144, 21);
            this.cbxPrecioMaximo.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(303, 402);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(349, 399);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(144, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(288, 438);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(526, 433);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarFiltro.TabIndex = 8;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(349, 433);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(144, 21);
            this.cbxCategoria.TabIndex = 9;
            // 
            // pbxImagenCatalogoFiltrado
            // 
            this.pbxImagenCatalogoFiltrado.Location = new System.Drawing.Point(724, 12);
            this.pbxImagenCatalogoFiltrado.Name = "pbxImagenCatalogoFiltrado";
            this.pbxImagenCatalogoFiltrado.Size = new System.Drawing.Size(234, 331);
            this.pbxImagenCatalogoFiltrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCatalogoFiltrado.TabIndex = 11;
            this.pbxImagenCatalogoFiltrado.TabStop = false;
            // 
            // dgvArticulosFiltrados
            // 
            this.dgvArticulosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosFiltrados.Location = new System.Drawing.Point(12, 12);
            this.dgvArticulosFiltrados.Name = "dgvArticulosFiltrados";
            this.dgvArticulosFiltrados.Size = new System.Drawing.Size(646, 331);
            this.dgvArticulosFiltrados.TabIndex = 10;
            // 
            // frmVentanaDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 468);
            this.Controls.Add(this.pbxImagenCatalogoFiltrado);
            this.Controls.Add(this.dgvArticulosFiltrados);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxPrecioMaximo);
            this.Controls.Add(this.cbxPrecioBase);
            this.Controls.Add(this.lblPrecioMaximo);
            this.Controls.Add(this.lblPrecioBase);
            this.Name = "frmVentanaDeBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo\\Buscar";
            this.Load += new System.EventHandler(this.frmVentanaDeBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCatalogoFiltrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosFiltrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblPrecioMaximo;
        private System.Windows.Forms.ComboBox cbxPrecioBase;
        private System.Windows.Forms.ComboBox cbxPrecioMaximo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pbxImagenCatalogoFiltrado;
        private System.Windows.Forms.DataGridView dgvArticulosFiltrados;
    }
}