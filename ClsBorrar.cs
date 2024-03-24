using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsBorrar
    {
        public static void Borrar()
        {
            // Solicitar al usuario el código del artículo que desea borrar
            Console.Write("Ingrese el código del artículo que desea borrar: ");
            int codigo = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < ClsAgregar.arregloArticulos.Length; i++)
            {
                if (ClsAgregar.arregloArticulos[i] != null && ClsAgregar.arregloArticulos[i].GetcodArt() == codigo)
                {
                    ClsAgregar.arregloArticulos[i] = null; // artículo borrado
                    encontrado = true;
                    Console.WriteLine("Artículo borrado correctamente.");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }
    }
}

