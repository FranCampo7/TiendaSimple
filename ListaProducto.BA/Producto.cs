using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProducto.BA
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; } 
        public decimal Cantidad { get; set; }
        public string UnMed { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
            
        }
        public Producto(string codigo,
                        string descripcion,
                        string cantidad,
                        string unmed,
                        string precio)

        {
            Codigo      = codigo;
            Descripcion = descripcion;
            UnMed       = unmed;
            Cantidad    = Convert.ToDecimal(cantidad);
            Precio      = Convert.ToDecimal(precio);
        }
    }
}

//for (int i = 0; i < listado.Length; i++)
//{
//    if (listado[i] != null)
//    {
//        lista.Text += $"peso (kg):{listado[i].peso}\t\naltura(cm):{listado[i].altura}" +
//            $"\t\nimc:{listado[i].imc}\t\ncategoria:{listado[i].categoria}\t\n\t\n";
//    }