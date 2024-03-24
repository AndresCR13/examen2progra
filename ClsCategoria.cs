using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class ClsCategoria
    {
        // Variable de tipo lista para almacenar las categorías posibles
        static List<ClsCategoria> categorias = new List<ClsCategoria>();
       
        public virtual void Promocion()
        {
            Console.WriteLine("Descuentos y Promociones");
        }

        // Lista de categorías disponibles
        private static List<Type> categoriasDisponibles = new List<Type>
        {
        typeof(ClsCategoria1),
        typeof(ClsCategoria2),
        typeof(ClsCategoria3)
        };
        public static void MostrarCategoriasDisponibles()
        {
            Console.WriteLine("Categorías Disponibles:");
            foreach (var categoria in categoriasDisponibles)
            {
                Console.WriteLine(categoria.Name);
            }
        }

        // Método para seleccionar una categoría aleatoria
        public static ClsCategoria SeleccionarCategoriaAleatoria()
        {
            Random rnd = new Random();
            int index = rnd.Next(categoriasDisponibles.Count);
            Type categoriaAleatoria = categoriasDisponibles[index];
            return (ClsCategoria)Activator.CreateInstance(categoriaAleatoria);
        }

        public static void ListadoCategorias() 
        {
            Console.WriteLine("Listado de Categorías:");
            foreach (var categoria in categorias)
            {
                categoria.Promocion(); // Llama al método promoción de cada categoría
            }
            static bool ExisteCategoria(List<ClsCategoria> categorias, ClsCategoria categoria)
            {
                return categorias.Contains(categoria);
            }
        }
        static bool ExisteCategoria(ClsCategoria categoria)
        {
            return categorias.Contains(categoria);
        }
    }

}   
