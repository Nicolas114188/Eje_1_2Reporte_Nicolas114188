
namespace Facturacion
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbNroFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbDetalleFactura = new System.Windows.Forms.DataGridView();
            this.CoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.cboFormaPago);
            this.gbFactura.Controls.Add(this.tbCliente);
            this.gbFactura.Controls.Add(this.tbNroFactura);
            this.gbFactura.Controls.Add(this.dtpFecha);
            this.gbFactura.Controls.Add(this.label4);
            this.gbFactura.Controls.Add(this.label3);
            this.gbFactura.Controls.Add(this.label2);
            this.gbFactura.Controls.Add(this.label1);
            this.gbFactura.Location = new System.Drawing.Point(23, 39);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(673, 170);
            this.gbFactura.TabIndex = 0;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(138, 105);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(210, 21);
            this.cboFormaPago.TabIndex = 3;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(138, 73);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(210, 20);
            this.tbCliente.TabIndex = 2;
            // 
            // tbNroFactura
            // 
            this.tbNroFactura.Location = new System.Drawing.Point(505, 27);
            this.tbNroFactura.Name = "tbNroFactura";
            this.tbNroFactura.Size = new System.Drawing.Size(137, 20);
            this.tbNroFactura.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(138, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(210, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formas de Pagos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. Factura";
            // 
            // dgbDetalleFactura
            // 
            this.dgbDetalleFactura.AllowUserToAddRows = false;
            this.dgbDetalleFactura.AllowUserToDeleteRows = false;
            this.dgbDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoArticulo,
            this.CoPrecio,
            this.CoCantidad});
            this.dgbDetalleFactura.Location = new System.Drawing.Point(71, 290);
            this.dgbDetalleFactura.Name = "dgbDetalleFactura";
            this.dgbDetalleFactura.ReadOnly = true;
            this.dgbDetalleFactura.Size = new System.Drawing.Size(345, 150);
            this.dgbDetalleFactura.TabIndex = 4;
            // 
            // CoArticulo
            // 
            this.CoArticulo.HeaderText = "Articulo";
            this.CoArticulo.Name = "CoArticulo";
            this.CoArticulo.ReadOnly = true;
            // 
            // CoPrecio
            // 
            this.CoPrecio.HeaderText = "Precio";
            this.CoPrecio.Name = "CoPrecio";
            this.CoPrecio.ReadOnly = true;
            // 
            // CoCantidad
            // 
            this.CoCantidad.HeaderText = "Cantidad";
            this.CoCantidad.Name = "CoCantidad";
            this.CoCantidad.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(459, 239);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(54, 531);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(313, 531);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(573, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Articulo";
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(71, 239);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(162, 21);
            this.cboArticulo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(326, 240);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total $";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(416, 470);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 5;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 566);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgbDetalleFactura);
            this.Controls.Add(this.gbFactura);
            this.MaximumSize = new System.Drawing.Size(732, 605);
            this.MinimumSize = new System.Drawing.Size(732, 605);
            this.Name = "FrmFacturacion";
            this.Text = "Facturación";
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbNroFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgbDetalleFactura;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoCantidad;
    }
}

