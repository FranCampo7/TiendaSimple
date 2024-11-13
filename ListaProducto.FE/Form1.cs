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
        public Productos Productos { get; set; } = new Productos();


        public Form1()
        {
            InitializeComponent();

            DGVProductos.DataSource = Productos.Lista;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Productos.ultimoid++;

            Producto pr = new Producto( Productos.ultimoid,
                                        txtDescripcion.Text,
                                        txtCantidad.Text,
                                        txtUnMed.Text,
                                        txtPrecio.Text);

            Productos.Agregar(pr);

          
        }
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Producto apr = new Producto(Convert.ToInt32(DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[0].Value),
                                                         txtDescripcion.Text,
                                                         txtCantidad.Text,
                                                         txtUnMed.Text,
                                                         txtPrecio.Text);
            
            Productos.Actualizar(apr);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            Productos.Borrar(Convert.ToInt32(DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[0].Value)); 
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //Producto prB = new Producto(txtBuscar.Text);
            //
            //Productos.Buscar(prB);
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtCantidad.Text = DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtUnMed.Text = DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = DGVProductos.Rows[DGVProductos.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }
    }
}
