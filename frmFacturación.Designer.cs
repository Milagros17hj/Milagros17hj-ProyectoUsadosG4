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
            this.lblFactura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblCajera = new System.Windows.Forms.Label();
            this.txtCajera = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.lblPrima = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.grvEncabezado.SuspendLayout();
            this.grbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvEncabezado
            // 
            this.grvEncabezado.Controls.Add(this.dateTimePicker1);
            this.grvEncabezado.Controls.Add(this.lblFecha);
            this.grvEncabezado.Controls.Add(this.txtCajera);
            this.grvEncabezado.Controls.Add(this.lblCajera);
            this.grvEncabezado.Controls.Add(this.comboBox2);
            this.grvEncabezado.Controls.Add(this.lblEntidad);
            this.grvEncabezado.Controls.Add(this.comboBox1);
            this.grvEncabezado.Controls.Add(this.lblTipoPago);
            this.grvEncabezado.Controls.Add(this.txtReserva);
            this.grvEncabezado.Controls.Add(this.lblReserva);
            this.grvEncabezado.Controls.Add(this.textBox1);
            this.grvEncabezado.Controls.Add(this.lblFactura);
            this.grvEncabezado.Location = new System.Drawing.Point(44, 69);
            this.grvEncabezado.Name = "grvEncabezado";
            this.grvEncabezado.Size = new System.Drawing.Size(716, 206);
            this.grvEncabezado.TabIndex = 0;
            this.grvEncabezado.TabStop = false;
            this.grvEncabezado.Text = "Encabezado";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(28, 38);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(55, 16);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(28, 92);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(62, 16);
            this.lblReserva.TabIndex = 2;
            this.lblReserva.Text = "Reserva:";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(144, 92);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.ReadOnly = true;
            this.txtReserva.Size = new System.Drawing.Size(100, 22);
            this.txtReserva.TabIndex = 3;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(28, 148);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(93, 16);
            this.lblTipoPago.TabIndex = 4;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(464, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(324, 143);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(122, 16);
            this.lblEntidad.TabIndex = 6;
            this.lblEntidad.Text = "Entidad Financiera:";
            // 
            // lblCajera
            // 
            this.lblCajera.AutoSize = true;
            this.lblCajera.Location = new System.Drawing.Point(324, 95);
            this.lblCajera.Name = "lblCajera";
            this.lblCajera.Size = new System.Drawing.Size(50, 16);
            this.lblCajera.TabIndex = 8;
            this.lblCajera.Text = "Cajera:";
            // 
            // txtCajera
            // 
            this.txtCajera.Location = new System.Drawing.Point(464, 95);
            this.txtCajera.Name = "txtCajera";
            this.txtCajera.ReadOnly = true;
            this.txtCajera.Size = new System.Drawing.Size(100, 22);
            this.txtCajera.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(324, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.textBox2);
            this.grbDetalle.Controls.Add(this.lblInteres);
            this.grbDetalle.Controls.Add(this.textBox3);
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
            this.grbDetalle.Location = new System.Drawing.Point(44, 281);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(716, 206);
            this.grbDetalle.TabIndex = 12;
            this.grbDetalle.TabStop = false;
            this.grbDetalle.Text = "Detalle";
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
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(97, 145);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(100, 22);
            this.txtSeguro.TabIndex = 11;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(372, 44);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 22);
            this.txtImpuesto.TabIndex = 12;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(372, 148);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 22);
            this.txtCuota.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(592, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 18;
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
            // frmFacturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.ControlBox = false;
            this.Controls.Add(this.grbDetalle);
            this.Controls.Add(this.grvEncabezado);
            this.Name = "frmFacturación";
            this.Text = "Facturación";
            this.grvEncabezado.ResumeLayout(false);
            this.grvEncabezado.PerformLayout();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grvEncabezado;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCajera;
        private System.Windows.Forms.Label lblCajera;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblInteres;
    }
}