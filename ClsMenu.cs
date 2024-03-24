using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    static class ClsMenu
    {
        public static string opcion;
        
        public static void Menu()
        {
            do
            {
                Console.WriteLine("--Menú Principal--");
                Console.WriteLine("a.Articulos");
                Console.WriteLine("b.Facturación");
                Console.WriteLine("c.Reporte");
                Console.WriteLine("d.Salir");
                Console.WriteLine("Elija una opción...");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        ClsSubmenu.Submenu();
                    break;
                    case "b":
                        ClsFactura.FacturaFinal(); break;
                    case "c":
                        ClsReporte.Reporte();break;
                    case "d":Console.WriteLine("Saliendo...");return;
                    default: Console.WriteLine("Elija una opción válida"); break;
                }
            } while (opcion != "d");

            
        }
        public static void Articulos(){ }
        public static void Facturacion(){ }
        public static void Reporte(){ }
        // salir 

    }
}
