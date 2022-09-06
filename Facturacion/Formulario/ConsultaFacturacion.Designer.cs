
namespace Facturacion.Formulario
{
    partial class ConsultaFacturacion
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColnroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 414);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(499, 414);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnroFactura,
            this.ColCliente,
            this.ColFecha});
            this.dgvFactura.Location = new System.Drawing.Point(434, 30);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(354, 150);
            this.dgvFactura.TabIndex = 0;
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.cboFormaPago);
            this.gbFactura.Controls.Add(this.tbCliente);
            this.gbFactura.Controls.Add(this.dtpFecha);
            this.gbFactura.Controls.Add(this.label4);
            this.gbFactura.Controls.Add(this.label3);
            this.gbFactura.Controls.Add(this.label2);
            this.gbFactura.Enabled = false;
            this.gbFactura.Location = new System.Drawing.Point(3, 12);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(425, 146);
            this.gbFactura.TabIndex = 1;
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
            // tbCantidad
            // 
            this.tbCantidad.Enabled = false;
            this.tbCantidad.Location = new System.Drawing.Point(315, 174);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad";
            // 
            // cboArticulo
            // 
            this.cboArticulo.Enabled = false;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(60, 174);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(162, 21);
            this.cboArticulo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Articulo";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Enabled = false;
            this.dgvDetalle.Location = new System.Drawing.Point(15, 220);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(400, 142);
            this.dgvDetalle.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(227, 414);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(362, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ColnroFactura
            // 
            this.ColnroFactura.HeaderText = "Nro De Factura";
            this.ColnroFactura.Name = "ColnroFactura";
            this.ColnroFactura.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ConsultaFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Name = "ConsultaFacturacion";
            this.Text = "ConsultaFacturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
    }
}