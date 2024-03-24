using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsInterfaces
    {
         // Definición de la interfaz IVendedor1
        public interface IVendedor1
        {
            string VentasContado();
        }

    // Definición de la interfaz IVendedor2
        public interface IVendedor2
        {
            string VentasCredito();
        }
    }
}
