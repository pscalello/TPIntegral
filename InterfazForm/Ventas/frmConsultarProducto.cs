using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace InterfazForm.Ventas
{
    public partial class frmConsultarProducto : Form
    {
        frmAltaVenta frmAltaVenta = new frmAltaVenta();
        private ProductosN productoN = new ProductosN();
        public List<object[]> listaDeProductos = new List<object[]>();
        public frmConsultarProducto()
        {
            InitializeComponent();
        }

        private void frmConsultarProducto_Load(object sender, EventArgs e)
        {
            llenaDataGriedProductos();
        }
        private void llenaDataGriedProductos()
        {
            List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();
            dgvProductos.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
            dgvProductos.Columns[0].Visible = false; // Oculto id
            dgvProductos.Columns["idCategoria"].HeaderText = "ID Categoria";
            dgvProductos.Columns[2].Visible = false; // Oculto idUsuario
            dgvProductos.Columns[3].Visible = false; // Oculto idProveedor
            dgvProductos.Columns["nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["precio"].HeaderText = "Precio";
            dgvProductos.Columns["stock"].HeaderText = "Stock";
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ResumeLayout();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            DatosProducto();
            frmAltaVenta.llenaDataGriedProductos();
            this.Close();
        }

        private void DatosProducto()
        {
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            frmAltaVenta.nombreProducto = filaSeleccionada.Cells[1].Value.ToString();
            frmAltaVenta.idProducto = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());
            frmAltaVenta.precioProducto = float.Parse(filaSeleccionada.Cells[5].Value.ToString());
            frmAltaVenta.stockProducto = Int32.Parse(filaSeleccionada.Cells[6].Value.ToString());
            listaDeProductos.Add(new object[] {frmAltaVenta.nombreProducto, frmAltaVenta.idProducto, frmAltaVenta.precioProducto, frmAltaVenta.stockProducto });
        }

    }
}
