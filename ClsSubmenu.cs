using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsSubmenu
    {
        public static int opcion;
        public static void Submenu()
        {
            do // bucle que se ejecuta almenos una vez 
            {
                Console.WriteLine("---Submenú---");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Borrar");
                Console.WriteLine("3. Consultar");
                Console.WriteLine("4. Menú Principal");
                Console.WriteLine("Elija una opción...");
              
                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion) // condicional que dependiendo de la opcion dada por el usuario muestra diferentes metodos
                    {
                        case 1: ClsAgregar.Agregar(); break;

                        case 2: ClsBorrar.Borrar(); break;

                        case 3: ClsConsultar.UsuarioConsu(); break;

                        case 4: Console.WriteLine("Saliendo..."); return; break;

                        default: Console.WriteLine("Digite una opción correcta"); break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese un número.");
                }

            } while (opcion != 7);

        }
    }
}    
