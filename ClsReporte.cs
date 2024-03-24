using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    internal class ClsReporte 
    {
        public static void Reporte() 
        {
            ClsConsultar.MostrarTodos();
            ClsCategoria.MostrarCategoriasDisponibles();
            ClsVendedor.TodosVendedores();
           
        }
    }
}
