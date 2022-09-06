using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    class Factura
    {
        private int nroFactura;
        private DateTime fecha;
        private int formaPago;
        private string cliente;
        private List<DetalleFactura> detalles;
        public Factura()
        {
            detalles = new List<DetalleFactura>();
        }
        public int NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public List<DetalleFactura> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        public void AgregarDetalle(DetalleFactura detalle)
        {
            detalles.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            detalles.RemoveAt(indice);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach(DetalleFactura item in Detalles)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }
    }
}
