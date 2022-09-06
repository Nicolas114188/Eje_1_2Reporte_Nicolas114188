using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio
{
    class FormaPago
    {
        private int nomPago;
        public FormaPago()
        {
            nomPago = 0;
        }
        public int NomPago
        {
            get { return nomPago; }
            set { nomPago = value; }
        }

    }
}
