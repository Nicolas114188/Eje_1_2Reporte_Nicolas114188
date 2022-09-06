
namespace Facturacion.Reporte
{
    partial class ReporteFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSFactura = new Facturacion.Reporte.DSFactura();
            this.DTFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTFacturaTableAdapter = new Facturacion.Reporte.DSFacturaTableAdapters.DTFacturaTableAdapter();
            this.dSFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvFactura
            // 
            this.rvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dSFacturaBindingSource;
            this.rvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFactura.LocalReport.ReportEmbeddedResource = "Facturacion.Reporte.ListaFactura.rdlc";
            this.rvFactura.Location = new System.Drawing.Point(0, 0);
            this.rvFactura.Name = "rvFactura";
            this.rvFactura.ServerReport.BearerToken = null;
            this.rvFactura.Size = new System.Drawing.Size(541, 289);
            this.rvFactura.TabIndex = 0;
            // 
            // DSFactura
            // 
            this.DSFactura.DataSetName = "DSFactura";
            this.DSFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTFacturaBindingSource
            // 
            this.DTFacturaBindingSource.DataMember = "DTFactura";
            this.DTFacturaBindingSource.DataSource = this.DSFactura;
            // 
            // DTFacturaTableAdapter
            // 
            this.DTFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // dSFacturaBindingSource
            // 
            this.dSFacturaBindingSource.DataSource = this.DSFactura;
            this.dSFacturaBindingSource.Position = 0;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 289);
            this.Controls.Add(this.rvFactura);
            this.Name = "ReporteFactura";
            this.Text = "Reporte Factura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFactura;
        private System.Windows.Forms.BindingSource DTFacturaBindingSource;
        private DSFactura DSFactura;
        private DSFacturaTableAdapters.DTFacturaTableAdapter DTFacturaTableAdapter;
        private System.Windows.Forms.BindingSource dSFacturaBindingSource;
    }
}