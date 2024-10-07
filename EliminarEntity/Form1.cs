using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliminarEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ProductoRepository cr = new ProductoRepository();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var productos = cr.ObtenerTodos();
            dgvProductos.DataSource = productos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var DeleteCliente = cr.DeleteCliente(Int32.Parse(tbxID.Text));
            var productos = cr.ObtenerTodos();
            dgvProductos.DataSource = productos;
            MessageBox.Show($"Se actualizaron: {DeleteCliente} filas");
        }
    }
}
