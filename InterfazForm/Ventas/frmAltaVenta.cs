using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace InterfazForm.Ventas
{
    public partial class frmAltaVenta : Form
    {
        public static string nombreCliente { get; set; }

        public static Guid idCliente { get; set; }

        public static Guid idProducto { get; set; }

        public static string nombreProducto { get; set; }

        public static int cantidadProducto { get; set; }

        public static float precioProducto { get; set; }

        public static int stockProducto { get; set; }

        public static int idCategoria { get; set; }

        public static bool agregaRenglon = false;


        public frmAltaVenta()
        {
            InitializeComponent();
        }

        private void frmAltaVenta_Load(object sender, EventArgs e)
        {

            // Agregar las columnas al DataGridView

            dgvVenta.Columns.Add("IDProducto", "ID Producto");
            dgvVenta.Columns.Add("Descripcion", "Descripcion");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("MontoUnitario", "Monto Unitario");
            dgvVenta.Columns.Add("MontoTotal", "Monto Total");
            dgvVenta.Columns.Add("IdCategoria", "idcategoria");

            dgvVenta.Columns[5].Visible = false;

            // Formato Columnas
            dgvVenta.Columns["Cantidad"].DefaultCellStyle.Format = "N0";      // N0 para formato numérico sin decimales y con separador de miles
            dgvVenta.Columns["MontoUnitario"].DefaultCellStyle.Format = "N2"; // N para formato numérico sin separador de miles ni decimales
            dgvVenta.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";   // N2 para formato numérico con dos decimales y separador de miles

        }

        private void llenaDataGriedProductos()
        {
            object[] fila1 = { idProducto, nombreProducto, cantidadProducto, precioProducto, cantidadProducto * precioProducto, idCategoria };
            dgvVenta.Rows.Add(fila1);
        }


        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente frmConsultarCliente = new frmConsultarCliente();
            frmConsultarCliente.ShowDialog();
        }

        private void frmAltaVenta_Activated(object sender, EventArgs e) //refresca el datagrid
        {
            txtCliente.Text = nombreCliente;
            if (agregaRenglon == true)
            {
                bool existeProducto = false;

                foreach (DataGridViewRow renglon in dgvVenta.Rows)
                {
                    if (dgvVenta.RowCount == 0)
                    {
                        existeProducto = false;
                        break;
                    }
                    else if (Guid.Parse(renglon.Cells[0].Value.ToString()) == idProducto)
                    {
                        existeProducto = true;
                        MessageBox.Show("Este producto ya fue agregado. Elimínelo y vuelva a agregarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                }
                if (existeProducto == false)
                {
                    llenaDataGriedProductos();

                }

                agregaRenglon = false;

            }

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                frmConsultarProducto frmConsultarProducto = new frmConsultarProducto();
                frmConsultarProducto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para agregar productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvVenta.SelectedRows.Count > 0)
                    {
                        DataGridViewRow filaSeleccionada = dgvVenta.SelectedRows[0]; //captura id que está oculta
                        dgvVenta.Rows.Remove(filaSeleccionada);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila de la grilla a eliminar.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la grilla a eliminar.");
            }

        }


        private void btnCalcularMonto_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            decimal descuentoelectro = 0;
            decimal descuentocliente = 0;
            decimal montofinal = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["MontoTotal"].Value != null && decimal.TryParse(fila.Cells["MontoTotal"].Value.ToString(), out decimal valor))
                {
                    suma = suma + valor;
                }
            }
            descuentoelectro = suma * 0.05m;
            descuentocliente = suma * 0.05m;
            montofinal = suma - descuentoelectro - descuentocliente;

            txtMontoTotal.Text = suma.ToString();
            txtPromoElectroHogar.Text = descuentoelectro.ToString();
            txtPromoClienteNuevo.Text = descuentocliente.ToString();
            txtMontoFinal.Text = montofinal.ToString();

        }
    }
}
