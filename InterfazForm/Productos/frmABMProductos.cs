//using Datos;
using Datos;
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

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0]; //captura id que está oculta
                                                                                     //MessageBox.Show(filaSeleccionada.Cells[0].Value.ToString());
                    Guid guid = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    bool eliminaProducto = productoN.EliminarProducto(guid);
                    if (eliminaProducto)
                    {
                        llenaDataGriedProductos();
                        MessageBox.Show("Producto eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Falló la eliminación, por favor vuelva a intentarlo");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la grilla a eliminar.");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
