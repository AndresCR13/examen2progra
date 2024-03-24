using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace examen2
{
    public class ClsArticulos
    {
        protected int codArt { get; set; }
        protected string NombreArt { get; set; }
        protected double Precio { get; set; }

        public string GetNombreArt()
        {
            return NombreArt;
        }
        public int GetcodArt()
        {
            return codArt;
        }

        public double GetPrecio()
        {
            return Precio;
        }

        public ClsArticulos() { }

        public ClsArticulos(int codArt, string nombreArt, double precio)
        {
            this.codArt = codArt;
            this.NombreArt = nombreArt;
            this.Precio = precio;
        }
        

    }   
}
