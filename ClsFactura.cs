using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsFactura : ClsArticulos
    {
        int[] montototal = new int[5];
        public static void facturacion()
        {
            Console.WriteLine("---Proceso de Facturación--- ");
            Boolean opcion = true;

            do
            {

                Console.Write("Ingrese el código del artículo que desea consultar: ");
                int codigo = int.Parse(Console.ReadLine());
                bool articuloEncontrado = false;

                foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
                {
                    if (articulo != null && articulo.GetcodArt() == codigo)
                    {
                        Console.WriteLine($"Nombre: {articulo.GetNombreArt()}");
                        Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                        articuloEncontrado = true;
                        break;

                    }
                }
                if (!articuloEncontrado)
                {
                    Console.WriteLine("Artículo no encontrado.");
                }

                Console.WriteLine("Desea verificar otro articulo S/N?");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s") // Si la respuesta no es "s" (sí), salir del bucle
                {
                    opcion = false;
                }

            } while (opcion);

            Console.WriteLine("Oprima enter para seguir con la Facturación");
            Console.ReadKey();
            ClsVendedor vendedorAleatorio = ClsVendedor.VendedorAleatorio();
            Console.WriteLine($"Nombre del vendedor : {vendedorAleatorio.Nombre}");
        }
        public static void FacturaFinal()
        {
            Console.WriteLine("---Proceso de Facturación--- ");
            Boolean opcion = true;

            do
            {

                Console.Write("Ingrese el código del artículo que desea consultar: ");
                int codigo = int.Parse(Console.ReadLine());
                bool articuloEncontrado = false;

                foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
                {
                    if (articulo != null && articulo.GetcodArt() == codigo)
                    {
                        Console.WriteLine($"Nombre: {articulo.GetNombreArt()}");
                        Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                        articuloEncontrado = true;
                        break;

                    }
                }
                if (!articuloEncontrado)
                {
                    Console.WriteLine("Artículo no encontrado.");
                }

                Console.WriteLine("Desea verificar otro articulo S/N?");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s") // Si la respuesta no es "s" (sí), salir del bucle
                {
                    opcion = false;
                }

            } while (opcion);
            do
            {
                ClsVendedor vendedorAleatorio = ClsVendedor.VendedorAleatorio();
                Console.WriteLine($"Vendedor asignado: {vendedorAleatorio.Nombre}");

                double totalPagar = 0;
                foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
                {
                    if (articulo != null)
                    {
                        totalPagar += articulo.GetPrecio();
                    }
                }
                // Imprimir la factura
                Console.WriteLine("\n--- Factura ---");
                foreach (ClsArticulos articulo in ClsAgregar.arregloArticulos)
                {
                    if (articulo != null)
                    {
                        Console.WriteLine($"Nombre: {articulo.GetNombreArt()}, Precio: {articulo.GetPrecio()}");
                    }
                }
                Console.WriteLine($"Total a pagar: {totalPagar}");

                // Aplicar la promoción correspondiente al vendedor
                vendedorAleatorio.AplicarPromocion(totalPagar);
                Console.WriteLine("\n¿Desea realizar otra factura? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
                {
                    break;
                }
                else
                {
                    // Reiniciar el arreglo de artículos para una nueva factura
                    Array.Clear(ClsAgregar.arregloArticulos, 0, ClsAgregar.arregloArticulos.Length);
                    ClsAgregar.indice = 0; // Utiliza el índice definido en ClsAgregar
                }
            } while (true);
        }
    }
}