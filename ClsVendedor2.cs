using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsVendedor2 : ClsInterfaces.IVendedor2
    {
        // Variable nombre
        public string Nombre { get; }

        // Variable categoría
        public string Categoria { get; }

        // Constructor de la clase ClsVendedor2
        public ClsVendedor2(string nombre, string categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }
        // Implementación del método VentasCredito
        public string VentasCredito()
        {
            return "Venta a crédito";
        }
    }
}
