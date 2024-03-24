using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsVendedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public ClsCategoria Categoria { get; set; }


        // de esta manera se crea un diccionario con valores fijos  
        public static Dictionary<int, string> vendedores = new Dictionary<int, string>
        {
            {1, "Juan"},
            {2, "Pepe"}
        };
        public ClsVendedor()// constructor en blanco
        {
            vendedores = new Dictionary<int, string>();
        }
        public Dictionary<int, string> ListadoVendedores()
        {
            return vendedores;
        }
        //metodo para obtener los datos del vendedor con el codigo 
        public static string NombreVendedor(int codigo)
        {
            if (vendedores.ContainsKey(codigo))
            {
                return vendedores[codigo];
            }
            else
            {
                return "El vendedor no existe.";
            }
        }
        //metodo para mostrar todos los vendedores en la reporte
        public static void TodosVendedores()
        {
            Console.WriteLine("----- VENDEDORES -----");
            foreach (var vendedor in vendedores)
            {
                // Seleccionar una categoría aleatoria para el vendedor
                ClsCategoria categoria = ClsCategoria.SeleccionarCategoriaAleatoria();

                // Verificar el código del vendedor y crear instancia correspondiente
                if (vendedor.Key == 1)
                {
                    Console.WriteLine("Vendedor 1");
                    ClsVendedor1 vendedor1 = new ClsVendedor1(vendedor.Value, categoria.GetType().Name);
                    Console.WriteLine($"Nombre: {vendedor1.Nombre}");
                    Console.WriteLine($"Tipo de venta: {vendedor1.VentasContado()}");
                    Console.WriteLine("Promoción de la categoría:");
                    categoria.Promocion();
                }
                else if (vendedor.Key == 2)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Vendedor 2");
                    ClsVendedor2 vendedor2 = new ClsVendedor2(vendedor.Value, categoria.GetType().Name);
                    ClsCategoria categoria2 = new ClsCategoria2();
                    Console.WriteLine($"Nombre: {vendedor2.Nombre}");
                    Console.WriteLine($"Tipo de venta: {vendedor2.VentasCredito()}");
                    Console.WriteLine("Promoción de la categoría:");
                    categoria.Promocion();
                }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Oprima enter  para seguir");
            Console.ReadKey();
        }        
         
        public static ClsVendedor VendedorAleatorio()
         {
            if (vendedores.Count > 0)
            {
                Random rnd = new Random();
                int indiceAleatorio = rnd.Next(0, vendedores.Count); // Genera un índice aleatorio dentro del rango del diccionario
                int codigoAleatorio = vendedores.Keys.ElementAt(indiceAleatorio); // Obtiene el código del vendedor aleatorio
                string nombreAleatorio = vendedores[codigoAleatorio]; // Obtiene el nombre del vendedor aleatorio
                return new ClsVendedor { Codigo = codigoAleatorio, Nombre = nombreAleatorio };
            }
            else
            {
                // Manejar el caso en el que no hay vendedores disponibles
                throw new InvalidOperationException("No hay vendedores disponibles.");
            }
        }
        public void AplicarPromocion(double totalPagar)
        {
            switch (Categoria)
            {
                case ClsCategoria1:
                    Console.WriteLine("Descuento de 15% aplicado.");
                    totalPagar *= 0.85; // Aplicar descuento del 15%
                    break;
                case ClsCategoria2:
                    Console.WriteLine("Promoción dos por uno aplicada.");
                    // Lógica para aplicar la promoción dos por uno si es necesaria
                    break;
                case ClsCategoria3:
                    Console.WriteLine("Todo a mitad de precio aplicado.");
                    totalPagar *= 0.5; // Aplicar descuento del 50%
                    break;
                default:
                    Console.WriteLine("Sin promoción.");
                    break;
            }
            Console.WriteLine($"Total a pagar después de la promoción: {totalPagar}");
        }
    }
}     

  

