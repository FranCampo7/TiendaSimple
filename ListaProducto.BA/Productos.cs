using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaProducto.BA
{
    public class Productos
    {
        public Producto[] Lista { get; set; } = new Producto[10];

        private int proximafila = 0;

        public void Agregar(Producto producto)
        {
            Lista[proximafila] = producto;
            proximafila = proximafila + 1;
        }

        public void Actualizar(Producto producto)
        {   
             
        }
        public void Borrar(Producto producto)
        {

        }
        public Producto Buscar(string codigo)
        {
            Producto pr = new Producto();
            return pr;
        }
    }
}
