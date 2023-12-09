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
            this.lblBusquedaTexto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBusquedaTexto
            // 
            this.lblBusquedaTexto.AutoSize = true;
            this.lblBusquedaTexto.Location = new System.Drawing.Point(12, 9);
            this.lblBusquedaTexto.Name = "lblBusquedaTexto";
            this.lblBusquedaTexto.Size = new System.Drawing.Size(55, 13);
            this.lblBusquedaTexto.TabIndex = 0;
            this.lblBusquedaTexto.Text = "Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(73, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 13);
            this.textBox1.TabIndex = 1;
            // 
            // frmVentanaDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 226);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBusquedaTexto);
            this.Name = "frmVentanaDeBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaTexto;
        private System.Windows.Forms.TextBox textBox1;
    }
}