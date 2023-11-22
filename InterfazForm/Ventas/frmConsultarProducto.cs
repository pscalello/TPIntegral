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
        frmAltaVenta frmAltaVenta;
        private ProductosN productoN = new ProductosN();
        public List<object[]> listaDeProductos = new List<object[]>();
        public frmConsultarProducto(Guid idUsuario)
        {
            InitializeComponent();
            frmAltaVenta frmAltaVenta = new frmAltaVenta(idUsuario);
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool cantidadvalidada = false;
            DatosProducto();
            cantidadvalidada = ValidacionCantidadProducto();
            if (cantidadvalidada)
            {
                frmAltaVenta.cantidadProducto = Convert.ToInt32(txtCantidadProducto.Text);
                frmAltaVenta.agregaRenglon = true;
                this.Close();
            }
            else
            {
                frmAltaVenta.agregaRenglon = false;
            }
        }

        private void DatosProducto()
        {
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            frmAltaVenta.nombreProducto = filaSeleccionada.Cells[4].Value.ToString();
            frmAltaVenta.idProducto = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());
            frmAltaVenta.precioProducto = float.Parse(filaSeleccionada.Cells[5].Value.ToString());
            frmAltaVenta.stockProducto = Int32.Parse(filaSeleccionada.Cells[6].Value.ToString());
            frmAltaVenta.idCategoria = Int32.Parse(filaSeleccionada.Cells[1].Value.ToString());
        }

        private bool ValidacionCantidadProducto()
        {
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            if (String.IsNullOrEmpty(txtCantidadProducto.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Int32.TryParse(txtCantidadProducto.Text, out int salida))
            {
                MessageBox.Show("Debe ingresar una cantidad del producto válida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (salida > Int32.Parse(filaSeleccionada.Cells[6].Value.ToString()))
            {
                MessageBox.Show("Debe ingresar una cantidad del producto que sea menor o igual al stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (salida >= 0.75 * Int32.Parse(filaSeleccionada.Cells[6].Value.ToString()))
            {
                MessageBox.Show("EL producto seleccionado quedará con un stock menor al 25%");
                return true;
                //Dado que el unico que puede ver Ventas es el Vendedor, será el unico que pueda ver este mensaje de stock crítico
            }
            else
            {
                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
