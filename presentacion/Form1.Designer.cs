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
            this.tsmBuscarPorFiltros = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarGeneral = new System.Windows.Forms.Button();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
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
            this.dgvArticulos.Size = new System.Drawing.Size(743, 411);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxImagenCatalogo
            // 
            this.pbxImagenCatalogo.Location = new System.Drawing.Point(761, 70);
            this.pbxImagenCatalogo.Name = "pbxImagenCatalogo";
            this.pbxImagenCatalogo.Size = new System.Drawing.Size(265, 411);
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
            this.tsmEliminarArticulo,
            this.tsmBuscarPorFiltros});
            this.tsmArticulosWork.Name = "tsmArticulosWork";
            this.tsmArticulosWork.Size = new System.Drawing.Size(66, 20);
            this.tsmArticulosWork.Text = "Articulos";
            // 
            // tsmAgregarArticulo
            // 
            this.tsmAgregarArticulo.Name = "tsmAgregarArticulo";
            this.tsmAgregarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarArticulo.Text = "Agregar";
            // 
            // tsmModificarArticulo
            // 
            this.tsmModificarArticulo.Name = "tsmModificarArticulo";
            this.tsmModificarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarArticulo.Text = "Modificar";
            // 
            // tsmEliminarArticulo
            // 
            this.tsmEliminarArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarFisico,
            this.tsmEliminarLogico});
            this.tsmEliminarArticulo.Name = "tsmEliminarArticulo";
            this.tsmEliminarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarArticulo.Text = "Eliminar";
            // 
            // tsmEliminarFisico
            // 
            this.tsmEliminarFisico.Name = "tsmEliminarFisico";
            this.tsmEliminarFisico.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarFisico.Text = "Fisico";
            // 
            // tsmEliminarLogico
            // 
            this.tsmEliminarLogico.Name = "tsmEliminarLogico";
            this.tsmEliminarLogico.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarLogico.Text = "Logico";
            // 
            // tsmBuscarPorFiltros
            // 
            this.tsmBuscarPorFiltros.Name = "tsmBuscarPorFiltros";
            this.tsmBuscarPorFiltros.Size = new System.Drawing.Size(180, 22);
            this.tsmBuscarPorFiltros.Text = "Buscar por filtros";
            this.tsmBuscarPorFiltros.Click += new System.EventHandler(this.tsmBuscar_Click);
            // 
            // btnBuscarGeneral
            // 
            this.btnBuscarGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarGeneral.Image")));
            this.btnBuscarGeneral.Location = new System.Drawing.Point(193, 44);
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
            this.tbxBuscador.Location = new System.Drawing.Point(12, 44);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(175, 20);
            this.tbxBuscador.TabIndex = 4;
            this.tbxBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBuscador_KeyPress);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 493);
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
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarPorFiltros;
        private System.Windows.Forms.Button btnBuscarGeneral;
        private System.Windows.Forms.TextBox tbxBuscador;
    }
}

