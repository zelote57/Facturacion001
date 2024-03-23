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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtSubTotalSuma = new System.Windows.Forms.TextBox();
            this.lblSubTotalSuma = new System.Windows.Forms.Label();
            this.txtSubTotalNoIva = new System.Windows.Forms.TextBox();
            this.txtSubTotalIva = new System.Windows.Forms.TextBox();
            this.lblSubTotalNoIva = new System.Windows.Forms.Label();
            this.lblSubTotalIva = new System.Windows.Forms.Label();
            this.lblEtiquetaFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificación = new System.Windows.Forms.Label();
            this.lblSecuencial = new System.Windows.Forms.Label();
            this.lblNumeroSecuencial = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbCabecera.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCabecera
            // 
            this.gbCabecera.Controls.Add(this.btnLimpiar);
            this.gbCabecera.Controls.Add(this.btnGrabar);
            this.gbCabecera.Controls.Add(this.txtValorTotal);
            this.gbCabecera.Controls.Add(this.lblValorTotal);
            this.gbCabecera.Controls.Add(this.txtIva);
            this.gbCabecera.Controls.Add(this.lblIva);
            this.gbCabecera.Controls.Add(this.txtSubTotalSuma);
            this.gbCabecera.Controls.Add(this.lblSubTotalSuma);
            this.gbCabecera.Controls.Add(this.txtSubTotalNoIva);
            this.gbCabecera.Controls.Add(this.txtSubTotalIva);
            this.gbCabecera.Controls.Add(this.lblSubTotalNoIva);
            this.gbCabecera.Controls.Add(this.lblSubTotalIva);
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
            this.gbCabecera.Size = new System.Drawing.Size(800, 209);
            this.gbCabecera.TabIndex = 0;
            this.gbCabecera.TabStop = false;
            this.gbCabecera.Text = "Cabecera";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(642, 151);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 33);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(641, 100);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(103, 33);
            this.btnGrabar.TabIndex = 18;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(402, 139);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(194, 20);
            this.txtValorTotal.TabIndex = 17;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(332, 142);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(402, 104);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(194, 20);
            this.txtIva.TabIndex = 15;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(332, 107);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 14;
            this.lblIva.Text = "IVA:";
            // 
            // txtSubTotalSuma
            // 
            this.txtSubTotalSuma.Location = new System.Drawing.Point(114, 168);
            this.txtSubTotalSuma.Name = "txtSubTotalSuma";
            this.txtSubTotalSuma.ReadOnly = true;
            this.txtSubTotalSuma.Size = new System.Drawing.Size(194, 20);
            this.txtSubTotalSuma.TabIndex = 13;
            // 
            // lblSubTotalSuma
            // 
            this.lblSubTotalSuma.AutoSize = true;
            this.lblSubTotalSuma.Location = new System.Drawing.Point(27, 171);
            this.lblSubTotalSuma.Name = "lblSubTotalSuma";
            this.lblSubTotalSuma.Size = new System.Drawing.Size(83, 13);
            this.lblSubTotalSuma.TabIndex = 12;
            this.lblSubTotalSuma.Text = "SubTotal Suma:";
            // 
            // txtSubTotalNoIva
            // 
            this.txtSubTotalNoIva.Location = new System.Drawing.Point(114, 137);
            this.txtSubTotalNoIva.Name = "txtSubTotalNoIva";
            this.txtSubTotalNoIva.ReadOnly = true;
            this.txtSubTotalNoIva.Size = new System.Drawing.Size(194, 20);
            this.txtSubTotalNoIva.TabIndex = 11;
            // 
            // txtSubTotalIva
            // 
            this.txtSubTotalIva.Location = new System.Drawing.Point(114, 104);
            this.txtSubTotalIva.Name = "txtSubTotalIva";
            this.txtSubTotalIva.ReadOnly = true;
            this.txtSubTotalIva.Size = new System.Drawing.Size(194, 20);
            this.txtSubTotalIva.TabIndex = 10;
            // 
            // lblSubTotalNoIva
            // 
            this.lblSubTotalNoIva.AutoSize = true;
            this.lblSubTotalNoIva.Location = new System.Drawing.Point(27, 140);
            this.lblSubTotalNoIva.Name = "lblSubTotalNoIva";
            this.lblSubTotalNoIva.Size = new System.Drawing.Size(70, 13);
            this.lblSubTotalNoIva.TabIndex = 9;
            this.lblSubTotalNoIva.Text = "SubTotal 0%:";
            // 
            // lblSubTotalIva
            // 
            this.lblSubTotalIva.AutoSize = true;
            this.lblSubTotalIva.Location = new System.Drawing.Point(27, 107);
            this.lblSubTotalIva.Name = "lblSubTotalIva";
            this.lblSubTotalIva.Size = new System.Drawing.Size(76, 13);
            this.lblSubTotalIva.TabIndex = 8;
            this.lblSubTotalIva.Text = "SubTotal 12%:";
            // 
            // lblEtiquetaFecha
            // 
            this.lblEtiquetaFecha.AutoSize = true;
            this.lblEtiquetaFecha.Location = new System.Drawing.Point(618, 56);
            this.lblEtiquetaFecha.Name = "lblEtiquetaFecha";
            this.lblEtiquetaFecha.Size = new System.Drawing.Size(40, 13);
            this.lblEtiquetaFecha.TabIndex = 7;
            this.lblEtiquetaFecha.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(684, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "2024-03-20";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(114, 62);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(482, 20);
            this.txtNumeroIdentificacion.TabIndex = 5;
            // 
            // lblTipoIdentificación
            // 
            this.lblTipoIdentificación.AutoSize = true;
            this.lblTipoIdentificación.Location = new System.Drawing.Point(27, 66);
            this.lblTipoIdentificación.Name = "lblTipoIdentificación";
            this.lblTipoIdentificación.Size = new System.Drawing.Size(81, 13);
            this.lblTipoIdentificación.TabIndex = 4;
            this.lblTipoIdentificación.Text = "RUC/CEDULA:";
            // 
            // lblSecuencial
            // 
            this.lblSecuencial.AutoSize = true;
            this.lblSecuencial.Location = new System.Drawing.Point(618, 26);
            this.lblSecuencial.Name = "lblSecuencial";
            this.lblSecuencial.Size = new System.Drawing.Size(63, 13);
            this.lblSecuencial.TabIndex = 3;
            this.lblSecuencial.Text = "Secuencial:";
            // 
            // lblNumeroSecuencial
            // 
            this.lblNumeroSecuencial.AutoSize = true;
            this.lblNumeroSecuencial.Location = new System.Drawing.Point(684, 26);
            this.lblNumeroSecuencial.Name = "lblNumeroSecuencial";
            this.lblNumeroSecuencial.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroSecuencial.TabIndex = 2;
            this.lblNumeroSecuencial.Text = "1";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(114, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(482, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.dataGridView1);
            this.gbDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalle.Location = new System.Drawing.Point(0, 209);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(800, 241);
            this.gbDetalle.TabIndex = 1;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle Facturación";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbCabecera);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.gbCabecera.ResumeLayout(false);
            this.gbCabecera.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblSubTotalIva;
        private System.Windows.Forms.Label lblSubTotalNoIva;
        private System.Windows.Forms.TextBox txtSubTotalIva;
        private System.Windows.Forms.TextBox txtSubTotalNoIva;
        private System.Windows.Forms.TextBox txtSubTotalSuma;
        private System.Windows.Forms.Label lblSubTotalSuma;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

