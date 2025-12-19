namespace ProyectoUsadosGrupo4
{
    partial class frmFacturación
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
            this.grvEncabezado = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEntidadFinanciera = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCajera = new System.Windows.Forms.TextBox();
            this.lblCajera = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.txtServiciosAdicionales = new System.Windows.Forms.TextBox();
            this.lblServiciosAdicionales = new System.Windows.Forms.Label();
            this.lblCitaId = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.lblPrima = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbReserva = new System.Windows.Forms.ComboBox();
            this.grvEncabezado.SuspendLayout();
            this.grbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvEncabezado
            // 
            this.grvEncabezado.Controls.Add(this.cmbReserva);
            this.grvEncabezado.Controls.Add(this.txtNombre);
            this.grvEncabezado.Controls.Add(this.txtEntidadFinanciera);
            this.grvEncabezado.Controls.Add(this.lblCitaId);
            this.grvEncabezado.Controls.Add(this.dateTimePicker1);
            this.grvEncabezado.Controls.Add(this.lblNombre);
            this.grvEncabezado.Controls.Add(this.lblFecha);
            this.grvEncabezado.Controls.Add(this.txtCajera);
            this.grvEncabezado.Controls.Add(this.lblCajera);
            this.grvEncabezado.Controls.Add(this.lblEntidad);
            this.grvEncabezado.Controls.Add(this.cmbTipoPago);
            this.grvEncabezado.Controls.Add(this.lblTipoPago);
            this.grvEncabezado.Controls.Add(this.txtFactura);
            this.grvEncabezado.Controls.Add(this.lblFactura);
            this.grvEncabezado.Location = new System.Drawing.Point(12, 12);
            this.grvEncabezado.Name = "grvEncabezado";
            this.grvEncabezado.Size = new System.Drawing.Size(1076, 140);
            this.grvEncabezado.TabIndex = 0;
            this.grvEncabezado.TabStop = false;
            this.grvEncabezado.Text = "Encabezado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(661, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(374, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // txtEntidadFinanciera
            // 
            this.txtEntidadFinanciera.Location = new System.Drawing.Point(935, 39);
            this.txtEntidadFinanciera.Name = "txtEntidadFinanciera";
            this.txtEntidadFinanciera.Size = new System.Drawing.Size(100, 22);
            this.txtEntidadFinanciera.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(545, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(217, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // txtCajera
            // 
            this.txtCajera.Location = new System.Drawing.Point(423, 89);
            this.txtCajera.Name = "txtCajera";
            this.txtCajera.ReadOnly = true;
            this.txtCajera.Size = new System.Drawing.Size(100, 22);
            this.txtCajera.TabIndex = 9;
            // 
            // lblCajera
            // 
            this.lblCajera.AutoSize = true;
            this.lblCajera.Location = new System.Drawing.Point(324, 89);
            this.lblCajera.Name = "lblCajera";
            this.lblCajera.Size = new System.Drawing.Size(50, 16);
            this.lblCajera.TabIndex = 8;
            this.lblCajera.Text = "Cajera:";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(788, 42);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(122, 16);
            this.lblEntidad.TabIndex = 6;
            this.lblEntidad.Text = "Entidad Financiera:";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(639, 38);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoPago.TabIndex = 5;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(523, 41);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(93, 16);
            this.lblTipoPago.TabIndex = 4;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(79, 35);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(100, 22);
            this.txtFactura.TabIndex = 1;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(18, 38);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(55, 16);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura:";
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.txtServiciosAdicionales);
            this.grbDetalle.Controls.Add(this.lblServiciosAdicionales);
            this.grbDetalle.Controls.Add(this.txtInteres);
            this.grbDetalle.Controls.Add(this.lblInteres);
            this.grbDetalle.Controls.Add(this.txtTotal);
            this.grbDetalle.Controls.Add(this.lblTotal);
            this.grbDetalle.Controls.Add(this.txtCuota);
            this.grbDetalle.Controls.Add(this.txtImpuesto);
            this.grbDetalle.Controls.Add(this.txtSeguro);
            this.grbDetalle.Controls.Add(this.lblImpuesto);
            this.grbDetalle.Controls.Add(this.txtPlazo);
            this.grbDetalle.Controls.Add(this.lblPlazo);
            this.grbDetalle.Controls.Add(this.lblCuota);
            this.grbDetalle.Controls.Add(this.lblSeguro);
            this.grbDetalle.Controls.Add(this.txtPrima);
            this.grbDetalle.Controls.Add(this.lblPrima);
            this.grbDetalle.Controls.Add(this.txtSubtotal);
            this.grbDetalle.Controls.Add(this.lblSubtotal);
            this.grbDetalle.Location = new System.Drawing.Point(12, 149);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(1076, 215);
            this.grbDetalle.TabIndex = 12;
            this.grbDetalle.TabStop = false;
            this.grbDetalle.Text = "Detalle";
            // 
            // txtServiciosAdicionales
            // 
            this.txtServiciosAdicionales.Location = new System.Drawing.Point(910, 41);
            this.txtServiciosAdicionales.Name = "txtServiciosAdicionales";
            this.txtServiciosAdicionales.Size = new System.Drawing.Size(100, 22);
            this.txtServiciosAdicionales.TabIndex = 22;
            // 
            // lblServiciosAdicionales
            // 
            this.lblServiciosAdicionales.AutoSize = true;
            this.lblServiciosAdicionales.Location = new System.Drawing.Point(763, 47);
            this.lblServiciosAdicionales.Name = "lblServiciosAdicionales";
            this.lblServiciosAdicionales.Size = new System.Drawing.Size(140, 16);
            this.lblServiciosAdicionales.TabIndex = 21;
            this.lblServiciosAdicionales.Text = "Servicios Adicionales:";
            // 
            // lblCitaId
            // 
            this.lblCitaId.AutoSize = true;
            this.lblCitaId.Location = new System.Drawing.Point(20, 87);
            this.lblCitaId.Name = "lblCitaId";
            this.lblCitaId.Size = new System.Drawing.Size(73, 16);
            this.lblCitaId.TabIndex = 19;
            this.lblCitaId.Text = "Id Reserva";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(592, 98);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(100, 22);
            this.txtInteres.TabIndex = 18;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(509, 101);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(50, 16);
            this.lblInteres.TabIndex = 17;
            this.lblInteres.Text = "Interés:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(592, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(509, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(372, 148);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 22);
            this.txtCuota.TabIndex = 14;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(372, 44);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 22);
            this.txtImpuesto.TabIndex = 12;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(97, 145);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(100, 22);
            this.txtSeguro.TabIndex = 11;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(232, 44);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(65, 16);
            this.lblImpuesto.TabIndex = 10;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(372, 98);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 22);
            this.txtPlazo.TabIndex = 9;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(232, 98);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(44, 16);
            this.lblPlazo.TabIndex = 8;
            this.lblPlazo.Text = "Plazo:";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(232, 146);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(99, 16);
            this.lblCuota.TabIndex = 6;
            this.lblCuota.Text = "Cuota Mensual:";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(28, 148);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(54, 16);
            this.lblSeguro.TabIndex = 4;
            this.lblSeguro.Text = "Seguro:";
            // 
            // txtPrima
            // 
            this.txtPrima.Location = new System.Drawing.Point(97, 92);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(100, 22);
            this.txtPrima.TabIndex = 3;
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Location = new System.Drawing.Point(28, 92);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(45, 16);
            this.lblPrima.TabIndex = 2;
            this.lblPrima.Text = "Prima:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(97, 38);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(28, 38);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(59, 612);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(168, 64);
            this.btnFacturar.TabIndex = 23;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(879, 628);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 64);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 188);
            this.dataGridView1.TabIndex = 25;
           
            // cmbReserva
            // 
            this.cmbReserva.FormattingEnabled = true;
            this.cmbReserva.Location = new System.Drawing.Point(112, 81);
            this.cmbReserva.Name = "cmbReserva";
            this.cmbReserva.Size = new System.Drawing.Size(121, 24);
            this.cmbReserva.TabIndex = 23;
            this.cmbReserva.SelectedIndexChanged += new System.EventHandler(this.cmbReserva_SelectedIndexChanged);
            // 
            // frmFacturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.grbDetalle);
            this.Controls.Add(this.grvEncabezado);
            this.Name = "frmFacturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frmFacturación_Load);
            this.grvEncabezado.ResumeLayout(false);
            this.grvEncabezado.PerformLayout();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grvEncabezado;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCajera;
        private System.Windows.Forms.Label lblCajera;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.Label lblPrima;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblCitaId;
        private System.Windows.Forms.TextBox txtEntidadFinanciera;
        private System.Windows.Forms.TextBox txtServiciosAdicionales;
        private System.Windows.Forms.Label lblServiciosAdicionales;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbReserva;
    }
}