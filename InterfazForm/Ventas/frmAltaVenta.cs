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

namespace InterfazForm.Ventas
{
    public partial class frmAltaVenta : Form
    {
        public static string nombreCliente { get; set; }
        public static Guid idCliente { get; set; }

        public static string nombreProducto { get; set; }

        public static Guid idProducto { get; set; }

        public static float precioProducto { get; set; }

        public static int stockProducto { get; set; }


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

        public void llenaDataGriedProductos() //VER SI DEBERIA SER PRIVADO
        {
            frmConsultarProducto frmConsultarProducto = new frmConsultarProducto();
            // Obtener la lista de productos desde el primer formulario
            List<object[]> listaDeProductos = frmConsultarProducto.listaDeProductos;

            // Rellenar el DataGridView con los datos de la lista
            foreach (var producto in listaDeProductos)
            {
                dgvVenta.Rows.Add(producto);
            }
        }
    

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente frmConsultarCliente = new frmConsultarCliente();
            frmConsultarCliente.ShowDialog();
        }

        private void frmAltaVenta_Activated(object sender, EventArgs e)
        {
            txtCliente.Text = nombreCliente;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmConsultarProducto frmConsultarProducto = new frmConsultarProducto();
            frmConsultarProducto.ShowDialog();
        }
    }
}
