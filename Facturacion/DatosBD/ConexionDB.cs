using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.DatosBD
{
    class ConexionDB
    {
        private string cadenaConeccion;
        private SqlConnection cnn;
        public ConexionDB()
        {
            cadenaConeccion = @"Data Source=PATO\NICOSQLSERVER;Initial Catalog=Facturacion_PII;Integrated Security=True";
            cnn = new SqlConnection(cadenaConeccion);
        }

        public DataTable EjecutarSP(string v)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = v;
            cmd.CommandType = CommandType.StoredProcedure;
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }

        internal int InicioFactura()
        {
            cnn.Open();
            SqlCommand cmdNro = new SqlCommand();
            cmdNro.Connection = cnn;
            cmdNro.CommandText = "SP_PROXIMO_ID";
            cmdNro.CommandType = CommandType.StoredProcedure;
            SqlParameter pNro = new SqlParameter();
            pNro.ParameterName = "@next";
            pNro.DbType = DbType.Int32;
            pNro.Direction = ParameterDirection.Output;
            cmdNro.Parameters.Add(pNro);
            cmdNro.ExecuteNonQuery();

            cnn.Close();
            return (int)pNro.Value;
        }

        public int EjecutarSPFacturacion(Factura oFactura)
        {
            int fila = 0;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERT_FACTURA", cnn,t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroFactura", oFactura.NroFactura);
                cmd.Parameters.AddWithValue("@fecha", oFactura.Fecha);
                cmd.Parameters.AddWithValue("@formaPago", oFactura.FormaPago);
                cmd.Parameters.AddWithValue("@cliente", oFactura.Cliente);
                fila = cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                foreach (DetalleFactura item in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERT_DetalleFactura", cnn,t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nroArticulo", item.pArticulo.NroArticulo);
                    cmdDetalle.Parameters.AddWithValue("@nroFactura", oFactura.NroFactura);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.pArticulo.PrecioUnitario);
                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch(Exception ex)
            {
                t.Rollback();
                
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return fila;
        }
   
    }
}
