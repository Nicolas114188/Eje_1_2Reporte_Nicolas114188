using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    class Articulo
    {
        private int nroArticulo;
        private string nomArticulo;
        private double precioUnitario;
        public Articulo(int nro, string nom, double pre)
        {
            nroArticulo = nro;
            nomArticulo = nom;
            precioUnitario = pre;
        }
        public int NroArticulo
        {
            get { return nroArticulo; }
            set { nroArticulo = value; }
        }
        public string NomArticulo

        {
            get { return nomArticulo; }
            set { nomArticulo = value; }
        }
        public double PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        public override string ToString()
        {
            return NomArticulo;
        }
    }
}
