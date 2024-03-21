namespace Facturacion
{
    partial class Form1
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
            this.gbCabecera = new System.Windows.Forms.GroupBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroSecuencial = new System.Windows.Forms.Label();
            this.lblSecuencial = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificación = new System.Windows.Forms.Label();
            this.lblEtiquetaFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCabecera
            // 
            this.gbCabecera.Controls.Add(this.lblEtiquetaFecha);
            this.gbCabecera.Controls.Add(this.lblFecha);
            this.gbCabecera.Controls.Add(this.txtNumeroIdentificacion);
            this.gbCabecera.Controls.Add(this.lblTipoIdentificación);
            this.gbCabecera.Controls.Add(this.lblSecuencial);
            this.gbCabecera.Controls.Add(this.lblNumeroSecuencial);
            this.gbCabecera.Controls.Add(this.txtCliente);
            this.gbCabecera.Controls.Add(this.lblCliente);
            this.gbCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCabecera.Location = new System.Drawing.Point(0, 0);
            this.gbCabecera.Name = "gbCabecera";
            this.gbCabecera.Size = new System.Drawing.Size(800, 132);
            this.gbCabecera.TabIndex = 0;
            this.gbCabecera.TabStop = false;
            this.gbCabecera.Text = "Cabecera";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalle.Location = new System.Drawing.Point(0, 132);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(800, 318);
            this.gbDetalle.TabIndex = 1;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle Facturación";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(114, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(329, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblNumeroSecuencial
            // 
            this.lblNumeroSecuencial.AutoSize = true;
            this.lblNumeroSecuencial.Location = new System.Drawing.Point(698, 39);
            this.lblNumeroSecuencial.Name = "lblNumeroSecuencial";
            this.lblNumeroSecuencial.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroSecuencial.TabIndex = 2;
            this.lblNumeroSecuencial.Text = "1";
            // 
            // lblSecuencial
            // 
            this.lblSecuencial.AutoSize = true;
            this.lblSecuencial.Location = new System.Drawing.Point(632, 39);
            this.lblSecuencial.Name = "lblSecuencial";
            this.lblSecuencial.Size = new System.Drawing.Size(63, 13);
            this.lblSecuencial.TabIndex = 3;
            this.lblSecuencial.Text = "Secuencial:";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(114, 78);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(194, 20);
            this.txtNumeroIdentificacion.TabIndex = 5;
            // 
            // lblTipoIdentificación
            // 
            this.lblTipoIdentificación.AutoSize = true;
            this.lblTipoIdentificación.Location = new System.Drawing.Point(27, 81);
            this.lblTipoIdentificación.Name = "lblTipoIdentificación";
            this.lblTipoIdentificación.Size = new System.Drawing.Size(81, 13);
            this.lblTipoIdentificación.TabIndex = 4;
            this.lblTipoIdentificación.Text = "RUC/CEDULA:";
            // 
            // lblEtiquetaFecha
            // 
            this.lblEtiquetaFecha.AutoSize = true;
            this.lblEtiquetaFecha.Location = new System.Drawing.Point(632, 69);
            this.lblEtiquetaFecha.Name = "lblEtiquetaFecha";
            this.lblEtiquetaFecha.Size = new System.Drawing.Size(40, 13);
            this.lblEtiquetaFecha.TabIndex = 7;
            this.lblEtiquetaFecha.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(698, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "2024-03-20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbCabecera);
            this.Name = "Form1";
            this.Text = "Facturación";
            this.gbCabecera.ResumeLayout(false);
            this.gbCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCabecera;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNumeroSecuencial;
        private System.Windows.Forms.Label lblSecuencial;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Label lblTipoIdentificación;
        private System.Windows.Forms.Label lblEtiquetaFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}

