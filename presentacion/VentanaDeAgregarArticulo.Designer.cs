namespace presentacion
{
    partial class frmVentanaDeAgregarArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxAgregarMarca = new System.Windows.Forms.ComboBox();
            this.cbxAgregarCate = new System.Windows.Forms.ComboBox();
            this.tbxImagenUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarNuevaMarca = new System.Windows.Forms.Button();
            this.btnAgregarNuevCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(55, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(104, 54);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 20);
            this.tbxCodigo.TabIndex = 1;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(104, 80);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(167, 20);
            this.tbxNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(104, 106);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(167, 20);
            this.tbxDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 109);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(58, 135);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(43, 162);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxAgregarMarca
            // 
            this.cbxAgregarMarca.FormattingEnabled = true;
            this.cbxAgregarMarca.Location = new System.Drawing.Point(104, 132);
            this.cbxAgregarMarca.Name = "cbxAgregarMarca";
            this.cbxAgregarMarca.Size = new System.Drawing.Size(167, 21);
            this.cbxAgregarMarca.TabIndex = 9;
            // 
            // cbxAgregarCate
            // 
            this.cbxAgregarCate.FormattingEnabled = true;
            this.cbxAgregarCate.Location = new System.Drawing.Point(104, 159);
            this.cbxAgregarCate.Name = "cbxAgregarCate";
            this.cbxAgregarCate.Size = new System.Drawing.Size(167, 21);
            this.cbxAgregarCate.TabIndex = 10;
            // 
            // tbxImagenUrl
            // 
            this.tbxImagenUrl.Location = new System.Drawing.Point(104, 186);
            this.tbxImagenUrl.Name = "tbxImagenUrl";
            this.tbxImagenUrl.Size = new System.Drawing.Size(167, 20);
            this.tbxImagenUrl.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Imagen (URL):";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(104, 212);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(167, 20);
            this.tbxPrecio.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio:";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(272, 260);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArticulo.TabIndex = 15;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnAgregarNuevaMarca
            // 
            this.btnAgregarNuevaMarca.Location = new System.Drawing.Point(277, 132);
            this.btnAgregarNuevaMarca.Name = "btnAgregarNuevaMarca";
            this.btnAgregarNuevaMarca.Size = new System.Drawing.Size(21, 21);
            this.btnAgregarNuevaMarca.TabIndex = 16;
            this.btnAgregarNuevaMarca.Text = "+";
            this.btnAgregarNuevaMarca.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaMarca.Click += new System.EventHandler(this.btnAgregarNuevaMarca_Click);
            // 
            // btnAgregarNuevCategoria
            // 
            this.btnAgregarNuevCategoria.Location = new System.Drawing.Point(277, 159);
            this.btnAgregarNuevCategoria.Name = "btnAgregarNuevCategoria";
            this.btnAgregarNuevCategoria.Size = new System.Drawing.Size(21, 21);
            this.btnAgregarNuevCategoria.TabIndex = 17;
            this.btnAgregarNuevCategoria.Text = "+";
            this.btnAgregarNuevCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarNuevCategoria.Click += new System.EventHandler(this.btnAgregarNuevCategoria_Click);
            // 
            // frmVentanaDeAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 295);
            this.Controls.Add(this.btnAgregarNuevCategoria);
            this.Controls.Add(this.btnAgregarNuevaMarca);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxImagenUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAgregarCate);
            this.Controls.Add(this.cbxAgregarMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmVentanaDeAgregarArticulo";
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmVentanaDeAgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxAgregarMarca;
        private System.Windows.Forms.ComboBox cbxAgregarCate;
        private System.Windows.Forms.TextBox tbxImagenUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnAgregarNuevaMarca;
        private System.Windows.Forms.Button btnAgregarNuevCategoria;
    }
}