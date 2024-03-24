using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class ClsAgregar 
    {
        public static ClsArticulos[] arregloArticulos = new ClsArticulos[5]; // Declarado como público para que sea accesible desde otras clases
        public static int indice = 0; // posición en el arreglo
        Random rnd = new Random(); // Objeto para generar números aleatorios


        public static void Agregar()
        {
            Console.WriteLine("--- Agregar Artículos ---");

            // Agregar artículos hasta que el usuario decida salir o hasta que el arreglo esté lleno
            string opcion;
            do
            {
                if (indice < arregloArticulos.Length)
                {
                    Console.Write("Digite el nombre del articulo: ");
                    string nombreArt = Console.ReadLine();

                    while (int.TryParse(nombreArt, out _) || string.IsNullOrWhiteSpace(nombreArt)) // validacion string 
                    {
                        Console.WriteLine("¡Nombre no válido! Por favor, ingrese un nombre sin números ni espacios en blanco.");
                        Console.Write("Nombre: ");
                        nombreArt = Console.ReadLine();
                    }

                    double precio;
                    Console.Write("Digite el precio del articulo: ");
                    while (!double.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("¡Precio no válido! Por favor, ingrese un valor numérico.");
                        Console.Write("Precio: ");
                    }

                    int codArt;
                    Console.Write("Digite el código del articulo: ");
                    while (!int.TryParse(Console.ReadLine(), out codArt)) // validación int 
                    {
                        Console.WriteLine("¡Código no válido! Por favor, ingrese un valor numérico.");
                        Console.Write("Código: ");
                    }

                    // Crear un nuevo artículo y lo agrega al arreglo
                    arregloArticulos[indice] = new ClsArticulos(codArt, nombreArt, precio);
                    indice++;

                    Console.WriteLine("Artículo agregado correctamente.\n");
                }
                else
                {
                    Console.WriteLine("El arreglo de artículos está lleno. No se pueden agregar más artículos.\n");
                    break; // Salir del bucle si el arreglo está lleno
                }

                do
                { // validacion para que no avance si no elige una opcion entre s/n
                    Console.Write("¿Desea agregar otro artículo? (s/n): ");
                    opcion = Console.ReadLine().ToLower();
                } while (opcion != "s" && opcion != "n");

            } while (opcion.ToLower() == "s" && indice < arregloArticulos.Length);
        }
    }
}

