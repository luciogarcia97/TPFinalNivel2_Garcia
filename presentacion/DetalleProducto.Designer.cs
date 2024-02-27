using System.Drawing;
using System.Windows.Forms;

namespace presentacion
{
    partial class frmDetalleProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleProducto));
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.tbxNombreProductoCombinado = new System.Windows.Forms.TextBox();
            this.pbxImagenMaestro = new System.Windows.Forms.PictureBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblDescripcionMaestro = new System.Windows.Forms.Label();
            this.tbxDescripcionMaestro = new System.Windows.Forms.TextBox();
            this.lblMarcaMaestro = new System.Windows.Forms.Label();
            this.tbxMarcaMaestro = new System.Windows.Forms.TextBox();
            this.lblCategoriaMaestro = new System.Windows.Forms.Label();
            this.tbxCategoriaMaestro = new System.Windows.Forms.TextBox();
            this.tbxPrecioMaestro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.Image")));
            this.btnRetroceder.Location = new System.Drawing.Point(17, 20);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(28, 26);
            this.btnRetroceder.TabIndex = 0;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // tbxNombreProductoCombinado
            // 
            this.tbxNombreProductoCombinado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.tbxNombreProductoCombinado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNombreProductoCombinado.Font = new System.Drawing.Font("Monserrat", 10F);
            this.tbxNombreProductoCombinado.Location = new System.Drawing.Point(129, 30);
            this.tbxNombreProductoCombinado.Name = "tbxNombreProductoCombinado";
            this.tbxNombreProductoCombinado.ReadOnly = true;
            this.tbxNombreProductoCombinado.Size = new System.Drawing.Size(197, 13);
            this.tbxNombreProductoCombinado.TabIndex = 1;
            // 
            // pbxImagenMaestro
            // 
            this.pbxImagenMaestro.Location = new System.Drawing.Point(16, 70);
            this.pbxImagenMaestro.Name = "pbxImagenMaestro";
            this.pbxImagenMaestro.Size = new System.Drawing.Size(268, 322);
            this.pbxImagenMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenMaestro.TabIndex = 2;
            this.pbxImagenMaestro.TabStop = false;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Monserrat", 12F, System.Drawing.FontStyle.Underline);
            this.lblIdProducto.Location = new System.Drawing.Point(51, 27);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(68, 16);
            this.lblIdProducto.TabIndex = 3;
            this.lblIdProducto.Text = "Producto:";
            // 
            // lblDescripcionMaestro
            // 
            this.lblDescripcionMaestro.AutoSize = true;
            this.lblDescripcionMaestro.Font = new System.Drawing.Font("Monserrat", 12F, System.Drawing.FontStyle.Underline);
            this.lblDescripcionMaestro.Location = new System.Drawing.Point(313, 70);
            this.lblDescripcionMaestro.Name = "lblDescripcionMaestro";
            this.lblDescripcionMaestro.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcionMaestro.TabIndex = 8;
            this.lblDescripcionMaestro.Text = "Descripcion:";
            // 
            // tbxDescripcionMaestro
            // 
            this.tbxDescripcionMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.tbxDescripcionMaestro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescripcionMaestro.Font = new System.Drawing.Font("Monserrat", 10F);
            this.tbxDescripcionMaestro.Location = new System.Drawing.Point(316, 89);
            this.tbxDescripcionMaestro.Multiline = true;
            this.tbxDescripcionMaestro.Name = "tbxDescripcionMaestro";
            this.tbxDescripcionMaestro.ReadOnly = true;
            this.tbxDescripcionMaestro.Size = new System.Drawing.Size(418, 60);
            this.tbxDescripcionMaestro.TabIndex = 9;
            // 
            // lblMarcaMaestro
            // 
            this.lblMarcaMaestro.AutoSize = true;
            this.lblMarcaMaestro.Font = new System.Drawing.Font("Monserrat", 12F, System.Drawing.FontStyle.Underline);
            this.lblMarcaMaestro.Location = new System.Drawing.Point(313, 178);
            this.lblMarcaMaestro.Name = "lblMarcaMaestro";
            this.lblMarcaMaestro.Size = new System.Drawing.Size(50, 16);
            this.lblMarcaMaestro.TabIndex = 10;
            this.lblMarcaMaestro.Text = "Marca:";
            // 
            // tbxMarcaMaestro
            // 
            this.tbxMarcaMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.tbxMarcaMaestro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMarcaMaestro.Font = new System.Drawing.Font("Monserrat", 10F);
            this.tbxMarcaMaestro.Location = new System.Drawing.Point(369, 181);
            this.tbxMarcaMaestro.Name = "tbxMarcaMaestro";
            this.tbxMarcaMaestro.ReadOnly = true;
            this.tbxMarcaMaestro.Size = new System.Drawing.Size(140, 13);
            this.tbxMarcaMaestro.TabIndex = 11;
            // 
            // lblCategoriaMaestro
            // 
            this.lblCategoriaMaestro.AutoSize = true;
            this.lblCategoriaMaestro.Font = new System.Drawing.Font("Monserrat", 12F, System.Drawing.FontStyle.Underline);
            this.lblCategoriaMaestro.Location = new System.Drawing.Point(515, 178);
            this.lblCategoriaMaestro.Name = "lblCategoriaMaestro";
            this.lblCategoriaMaestro.Size = new System.Drawing.Size(73, 16);
            this.lblCategoriaMaestro.TabIndex = 12;
            this.lblCategoriaMaestro.Text = "Categoria:";
            // 
            // tbxCategoriaMaestro
            // 
            this.tbxCategoriaMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.tbxCategoriaMaestro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCategoriaMaestro.Font = new System.Drawing.Font("Monserrat", 10F);
            this.tbxCategoriaMaestro.Location = new System.Drawing.Point(594, 181);
            this.tbxCategoriaMaestro.Name = "tbxCategoriaMaestro";
            this.tbxCategoriaMaestro.ReadOnly = true;
            this.tbxCategoriaMaestro.Size = new System.Drawing.Size(140, 13);
            this.tbxCategoriaMaestro.TabIndex = 13;
            // 
            // tbxPrecioMaestro
            // 
            this.tbxPrecioMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.tbxPrecioMaestro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrecioMaestro.Font = new System.Drawing.Font("Monserrat", 12F);
            this.tbxPrecioMaestro.ForeColor = System.Drawing.Color.Purple;
            this.tbxPrecioMaestro.Location = new System.Drawing.Point(315, 243);
            this.tbxPrecioMaestro.Name = "tbxPrecioMaestro";
            this.tbxPrecioMaestro.ReadOnly = true;
            this.tbxPrecioMaestro.Size = new System.Drawing.Size(143, 19);
            this.tbxPrecioMaestro.TabIndex = 14;
            // 
            // frmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(753, 416);
            this.Controls.Add(this.tbxPrecioMaestro);
            this.Controls.Add(this.tbxCategoriaMaestro);
            this.Controls.Add(this.lblCategoriaMaestro);
            this.Controls.Add(this.tbxMarcaMaestro);
            this.Controls.Add(this.lblMarcaMaestro);
            this.Controls.Add(this.tbxDescripcionMaestro);
            this.Controls.Add(this.lblDescripcionMaestro);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.pbxImagenMaestro);
            this.Controls.Add(this.tbxNombreProductoCombinado);
            this.Controls.Add(this.btnRetroceder);
            this.Name = "frmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del producto";
            this.Load += new System.EventHandler(this.frmDetalleProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMaestro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.TextBox tbxNombreProductoCombinado;
        private System.Windows.Forms.PictureBox pbxImagenMaestro;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblDescripcionMaestro;
        private System.Windows.Forms.TextBox tbxDescripcionMaestro;
        private System.Windows.Forms.Label lblMarcaMaestro;
        private System.Windows.Forms.TextBox tbxMarcaMaestro;
        private System.Windows.Forms.Label lblCategoriaMaestro;
        private System.Windows.Forms.TextBox tbxCategoriaMaestro;
        private System.Windows.Forms.TextBox tbxPrecioMaestro;
    }
}