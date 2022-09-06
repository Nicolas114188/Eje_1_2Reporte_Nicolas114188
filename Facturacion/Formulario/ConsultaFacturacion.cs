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

//falta el codigo
namespace Facturacion.Formulario
{
    public partial class ConsultaFacturacion : Form
    {
        private ConexionDB helper;
        public ConsultaFacturacion()
        {
            InitializeComponent();
            helper = new ConexionDB();
            CargarCombo("SP_SELECT_FormaPago", "id_forma_pago", "forma_pago",cboFormaPago);
            CargarCombo("SP_SELECT_Articulos", "id_articulo", "nombre", cboArticulo);
            cargarLista("SP_SELECT_Factura",dgvFactura);
            //cargarLista("SP_SELECT_DetalleFactura",dgvDetalle);
        }

        private void cargarLista(string v, DataGridView dgv)
        {
            dgv.Rows.Clear();
            DataTable tabla = helper.EjecutarSP(v);
            dgv.DataSource = tabla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Editar la Factura?","Información",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Habilitar();
                
            }
        }

        private void CargarCombo(string v1, string v2, string v3, ComboBox cbo)
        {
            DataTable tabla = helper.EjecutarSP(v1);
            cbo.DataSource = tabla;
            cbo.DisplayMember = v2;
            cbo.ValueMember = v3;
        }

        private void Habilitar()
        {
            gbFactura.Enabled = true;
            cboArticulo.Enabled = true;
            tbCantidad.Enabled = true;
            btnRegistrar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar la Factura?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
