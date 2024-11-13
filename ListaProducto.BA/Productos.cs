using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaProducto.BA
{
    public class Productos
    {
        public DataTable Lista { get; set; } = new DataTable();


        public static int ultimoid { get; set; } = 0;

        public Productos()
        {
            Lista.TableName = "ListaProductos";
            Lista.Columns.Add("Codigo", typeof(int));
            Lista.Columns.Add("Descripcion");
            Lista.Columns.Add("Cantidad");
            Lista.Columns.Add("Unidad Medida");
            Lista.Columns.Add("Precio", typeof(int));
            LeerArchivo();
            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                if (Convert.ToInt32(Lista.Rows[i][0]) > ultimoid)
                {
                    ultimoid = Convert.ToInt32(Lista.Rows[i][0]);
                }

            }

        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Productos.xml"))
            {
                Lista.ReadXml("Productos.xml");

            }
        }

        public void Agregar(Producto producto)
        {

            Lista.Rows.Add();
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Codigo"] = producto.Codigo;
            Lista.Rows[NuevoRenglon]["Descripcion"] = producto.Descripcion;
            Lista.Rows[NuevoRenglon]["Cantidad"] = producto.Cantidad;
            Lista.Rows[NuevoRenglon]["Unidad Medida"] = producto.UnMed;
            Lista.Rows[NuevoRenglon]["Precio"] = producto.Precio;

            Lista.WriteXml("Productos.xml");
        }

        //public void Actualizar(string codigo,
        //                string descripcion,
        //                string cantidad,
        //                string unmed,
        //                string precio)
        //{
        //    Producto producto = new Producto();
        //}
        public void Borrar(Producto prB)
        {
            
        }
        //public Producto Buscar(string prB)
        //{
        //    Producto prB = Lista;
        //
        //    if (prB != null)
        //    {
        //        txtNombre.Text = perF.Nombre;
        //        txtApellido.Text = perF.Apellido;
        //        txtEdad.Text = perF.Edad.ToString();
        //
        //        txtNombre.Focus();
        //    }
        //    else
        //    {
        //        
        //    }
        //}
    }
}
