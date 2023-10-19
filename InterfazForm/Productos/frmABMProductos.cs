//using Datos;
using Entidad;
using InterfazForm.Proveedores;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Productos
{
    public partial class frmABMProductos : Form
    {
        private ProductosN productoN = new ProductosN();
        public frmABMProductos()
        {
            InitializeComponent();
        }


        private void frmABMProductos_Load(object sender, EventArgs e)
        {
            llenaDataGriedProductos();
        }
        private void llenaDataGriedProductos()
        {
            List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();
            dgvProductos.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
            //dgvProductos.Columns[0].Visible = false; // Oculto id
            dgvProductos.Columns[1].Visible = false; // Oculto idUsuario
            dgvProductos.Columns[2].Visible = false; // Oculto idProveedor
            dgvProductos.Columns["idCategoria"].HeaderText = "ID Categoria";
            dgvProductos.Columns["nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["precio"].HeaderText = "Precio";
            dgvProductos.Columns["stock"].HeaderText = "Stock";
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ResumeLayout();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.ShowDialog();
        }


    }
}
