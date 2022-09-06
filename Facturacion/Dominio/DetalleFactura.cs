using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    class DetalleFactura
    {
        private Articulo articulo;
        private int cantidad;
        private int nroFactura;
        public DetalleFactura(Articulo a, int c)
        {
            cantidad = c;
            articulo = a;
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Articulo pArticulo
        {
            get { return articulo; }
            set { articulo = value; }
        }
        public double CalcularSubtotal()
        {
            return articulo.PrecioUnitario * Cantidad;
        }
    }
}
