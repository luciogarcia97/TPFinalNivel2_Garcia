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
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblCodigoMaestro = new System.Windows.Forms.Label();
            this.lblNombreMaestro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(12, 12);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(28, 26);
            this.btnRetroceder.TabIndex = 0;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.Location = new System.Drawing.Point(87, 16);
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.Size = new System.Drawing.Size(197, 20);
            this.tbxNombreProducto.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 322);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(46, 19);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(18, 13);
            this.lblIdProducto.TabIndex = 3;
            this.lblIdProducto.Text = "ID";
            // 
            // lblCodigoMaestro
            // 
            this.lblCodigoMaestro.AutoSize = true;
            this.lblCodigoMaestro.Location = new System.Drawing.Point(339, 73);
            this.lblCodigoMaestro.Name = "lblCodigoMaestro";
            this.lblCodigoMaestro.Size = new System.Drawing.Size(46, 13);
            this.lblCodigoMaestro.TabIndex = 4;
            this.lblCodigoMaestro.Text = "Codigo: ";
            // 
            // lblNombreMaestro
            // 
            this.lblNombreMaestro.AutoSize = true;
            this.lblNombreMaestro.Location = new System.Drawing.Point(338, 113);
            this.lblNombreMaestro.Name = "lblNombreMaestro";
            this.lblNombreMaestro.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMaestro.TabIndex = 5;
            this.lblNombreMaestro.Text = "Nombre:";
            // 
            // frmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombreMaestro);
            this.Controls.Add(this.lblCodigoMaestro);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxNombreProducto);
            this.Controls.Add(this.btnRetroceder);
            this.Name = "frmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblCodigoMaestro;
        private System.Windows.Forms.Label lblNombreMaestro;
    }
}