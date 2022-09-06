using Facturacion.DatosBD;
using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class FrmFacturacion : Form
    {
      private ConexionDB helper;
      private int fila;
      private Factura oFactura; 
        public FrmFacturacion()
        {
            InitializeComponent();
            helper = new ConexionDB();
            oFactura = new Factura();
            fila = 0;
            ProximaFactura();
            CargarCombo("SP_SELECT_FormaPago", "id_forma_pago", "forma_pago", cboFormaPago);
            CargarCombo("SP_SELECT_Articulos", "id_articulo","nombre",cboArticulo);
        }

        private void ProximaFactura()
        {
            DataTable table = helper.EjecutarSP("SP_SELECT_Factura");
            if (table is null)
                tbNroFactura.Text = "1";
            else
            {
                int next = helper.InicioFactura();
                if (next > 0)
                {
                    tbNroFactura.Text = next.ToString();
                    tbNroFactura.Enabled = false;
                }
                else
                    MessageBox.Show("No valido número de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CargarCombo(string v,string valorM,string displeyM, ComboBox cbo)
        {
            DataTable tabla = helper.EjecutarSP(v);
            cbo.DataSource = tabla;
            cbo.DisplayMember = displeyM;
            cbo.ValueMember = valorM;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir Facturación", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;

                
                if (String.IsNullOrEmpty(tbCantidad.Text))
                    MessageBox.Show("Ingrese una cantidad","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRowView item =(DataRowView)cboArticulo.SelectedItem;
                    int nroArt = Convert.ToInt32(item.Row.ItemArray[0]);
                    string nomArt = item.Row.ItemArray[1].ToString();
                    double preArt = Convert.ToDouble(item.Row.ItemArray[2]);
                    Articulo a = new Articulo(nroArt,nomArt,preArt);
                    int c = Convert.ToInt32(tbCantidad.Text);
                    DetalleFactura oDetalleFactura = new DetalleFactura(a,c);
                    oFactura.AgregarDetalle(oDetalleFactura);
                    dgbDetalleFactura.Rows.Add(new object[] {item.Row.ItemArray[1],item.Row.ItemArray[2],tbCantidad.Text });
                    
                    TotalFacturado();
                }
            
            
        }

        private void TotalFacturado()
        {
            double total = oFactura.CalcularTotal();
            tbTotal.Text = total.ToString();
        }

        private bool Validar()
        {
            bool val = true;
            if (String.IsNullOrEmpty(tbNroFactura.Text) || String.IsNullOrEmpty(tbCliente.Text))
                val = false;
            if (String.IsNullOrEmpty(tbCantidad.Text))
            {
                val = false;
            }
            return val;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                oFactura.NroFactura = Convert.ToInt32(tbNroFactura.Text);
                oFactura.Fecha = dtpFecha.Value;
                oFactura.Cliente = tbCliente.Text;
                oFactura.FormaPago = Convert.ToInt32(cboFormaPago.SelectedValue);
                fila = helper.EjecutarSPFacturacion(oFactura);
                
            }
            else
                MessageBox.Show("Primero registre todo los datos", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (fila > 0)
            {
                MessageBox.Show("Registro de facturación completa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("Error al registrar factura!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            ProximaFactura();
            dtpFecha.Value = DateTime.Now;
            tbCliente.Text = "";
            tbCantidad.Text = "";
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar los datos", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }
    }
}
