using Entidad;
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

namespace InterfazForm.Ventas
{
    public partial class frmABMVentas : Form
    {
        public int hostUsuario;
        public Guid idUsuario;
        VentaN ventaN = new VentaN();
        public frmABMVentas(Guid idUsuario, int hostUsuario)
        {
            this.idUsuario = idUsuario;
            this.hostUsuario = hostUsuario;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMVentas_Load(object sender, EventArgs e)
        {
            switch (hostUsuario)
            {
                case 1: // Vendedor
                    btnDevolucion.Enabled = false;
                    break;
                case 2: // Supervisor
                    btnAgregar.Enabled = false;
                    break;
            }
            llenaDataGridVentas();
        }

        private void llenaDataGridVentas()
        {
            //BindingList<RespuestaConsultaVenta> listaVentas = ventaN.listarVentas();
            //dgvVentas.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            //dgvVentas.DataSource = null;
            //dgvVentas.DataSource = listaVentas;
            //dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvVentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ////dgvVentas.Columns["id"].HeaderText = "Id";
            ////dgvVentas.Columns["cantidad"].HeaderText = "Cantidad de Productos Vendidos";
            ////dgvVentas.Columns["idCliente"].HeaderText = "Cliente";
            ////dgvVentas.Columns["fechaAlta"].HeaderText = "Fecha";
            ////dgvVentas.Columns["estado"].HeaderText = "Estado";
            //dgvVentas.ResumeLayout();

            //// Agregar las columnas al DataGridView

            //dgvVentas.Columns.Add("id", "ID Producto");
            //dgvVentas.Columns.Add("Descripcion", "Descripcion");
            //dgvVentas.Columns.Add("Cantidad", "Cantidad");
            //dgvVentas.Columns.Add("MontoUnitario", "Monto Unitario");
            //dgvVentas.Columns.Add("MontoTotal", "Monto Total Previo A Descuento");
            //dgvVentas.Columns.Add("IdCategoria", "idcategoria");

            //dgvVentas.Columns[5].Visible = false;

            // Formato Columnas
            dgvVentas.Columns["cantidad"].DefaultCellStyle.Format = "N0";      // N0 para formato numérico sin decimales y con separador de miles

            List<RespuestaConsultaVenta> listaVentas = ventaN.listarVentas();
            
            foreach (RespuestaConsultaVenta venta in listaVentas)
            {
                string textoEstado = "";
                if (venta.estado == 0)
                {
                    textoEstado = "Devuelto";
                } else if (venta.estado == 1)
                {
                    textoEstado = "Entregado";
                }
                string fechaLimpia = venta.fechaAlta.Substring(0, 10);
                object[] fila = { venta.id, venta.cantidad, venta.cliente, fechaLimpia, textoEstado };
                dgvVentas.Rows.Add(fila);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaVenta frmAltaVenta = new frmAltaVenta(idUsuario);
            frmAltaVenta.ShowDialog();
        }
    }
}
