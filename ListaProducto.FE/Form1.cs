using ListaProducto.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProducto.FE
{
    public partial class Form1 : Form
    {

        Productos ListaProductos = new Productos();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto(txtCodigo.Text,
                                        txtDescripcion.Text,
                                        txtUnMed.Text,
                                        txtCantidad.Text,
                                        txtPrecio.Text);

            ListaProductos.Agregar(pr);

        }
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto(txtCodigo.Text,
                                        txtDescripcion.Text,
                                        txtUnMed.Text,
                                        txtCantidad.Text,
                                        txtPrecio.Text);

            ListaProductos.Actualizar(pr);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }

        private void lblPR_Click(object sender, EventArgs e)
        {

        }

        private void txtbListado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
