using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class ClsVendedor1 : ClsInterfaces.IVendedor1
    {

        // Variable nombre
        public string Nombre { get; }

        // Variable categoría
        public string Categoria { get; }

        // Constructor de la clase ClsVendedor1
        public ClsVendedor1(string nombre, string categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }
        // Implementación del método VentasContado
        public string VentasContado()
        {
            return "Venta al contado";
        }

    }
}
