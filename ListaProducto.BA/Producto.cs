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
        private string text;

        public int Codigo { get; set; }
        public string Descripcion { get; set; } 
        public decimal Cantidad { get; set; }
        public string UnMed { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
            
        }
        public Producto(int codigo,
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

        public Producto(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            string res = "";

            res =   "Codigo: " + Codigo + " " +
                    "Descripcion: " + Descripcion + " " +
                    "Unidad de medida: " + UnMed + " " +
                    "Cantidad: " + Cantidad.ToString() + " " +
                    "Precio: " + Precio.ToString();
            return res; 
        }
    }
}

