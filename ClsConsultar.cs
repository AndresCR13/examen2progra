using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsConsultar 
    {
        private static ClsArticulos[]? arregloArticulos;

       
        public static void UsuarioConsu()
        {
            // Solicitar al usuario qué tipo de consulta desea realizar
            Console.WriteLine("¿Qué tipo de consulta desea realizar?");
            Console.WriteLine("a) Consultar por código");
            Console.WriteLine("b) Consultar por nombre");
            Console.WriteLine("c) Mostrar todos los artículos");
            Console.Write("Ingrese su opción (a, b o c): ");
            string opcion = Console.ReadLine();
            // Realizar la consulta según la opción seleccionada
            switch (opcion)
            {
                case "a":
                    ConsultarPorCodigo();
                    break;
                case "b":
                    ConsultarPorNombre();
                    break;
                case "c":
                    MostrarTodos();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        }

        public static void ConsultarPorCodigo()
        {
            Console.Write("Ingrese el código del artículo que desea consultar: ");
            int codigo = int.Parse(Console.ReadLine());

            foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
            {
                if (articulo != null && articulo.GetcodArt() == codigo)
                {
                    Console.WriteLine($"Nombre: {articulo.GetNombreArt()}");
                    Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                    return;
                }
            }

            Console.WriteLine("Artículo no encontrado.");
        }

        public static void ConsultarPorNombre()
        {
            Console.Write("Ingrese el nombre del artículo que desea consultar: ");
            string nombre = Console.ReadLine();

            bool encontrado = false;

            foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
            {
                if (articulo != null && articulo.GetNombreArt() == nombre)
                {
                    Console.WriteLine($"Nombre: {articulo.GetNombreArt()}");
                    Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }

        public static void MostrarTodos()
        {
            Console.WriteLine("Lista de Artículos:");

            foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
            {
                if (articulo != null)
                {
                    Console.WriteLine($"Nombre: {articulo.GetNombreArt()}");
                    Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                    Console.WriteLine($"Código: {articulo.GetcodArt()}");
                    Console.WriteLine();
                }
            }
        }
    }
}

