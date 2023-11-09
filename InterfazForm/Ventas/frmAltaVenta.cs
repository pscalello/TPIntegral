using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Ventas
{
    public partial class frmAltaVenta : Form
    {
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

            // Formato Columnas
            dgvVenta.Columns["Cantidad"].DefaultCellStyle.Format = "N0";      // N0 para formato numérico sin decimales y con separador de miles
            dgvVenta.Columns["MontoUnitario"].DefaultCellStyle.Format = "N"; // N para formato numérico sin separador de miles ni decimales
            dgvVenta.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";   // N2 para formato numérico con dos decimales y separador de miles
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente frmConsultarCliente = new frmConsultarCliente();
            frmConsultarCliente.ShowDialog();
        }
    }
}
