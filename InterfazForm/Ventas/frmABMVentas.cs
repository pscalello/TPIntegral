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
            try
            {
                llenaDataGridVentas();
            }
            catch
            {
                MessageBox.Show("Hubo un error al cargar las ventas.");
            }
        }

        private void llenaDataGridVentas()
        {
            try
            {
                // Formato Columna
                dgvVentas.Columns["cantidad"].DefaultCellStyle.Format = "N0";      // N0 para formato numérico sin decimales y con separador de miles
                dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                List<RespuestaConsultaVenta> listaVentas = ventaN.listarVentas();

                foreach (RespuestaConsultaVenta venta in listaVentas)
                {
                    string textoEstado = "";
                    if (venta.estado == 0)
                    {
                        textoEstado = "Devuelto";
                    }
                    else if (venta.estado == 1)
                    {
                        textoEstado = "Entregado";
                    }
                    string fechaLimpia = venta.fechaAlta.Substring(0, 10);
                    object[] fila = { venta.id, venta.cantidad, venta.cliente, fechaLimpia, textoEstado };
                    dgvVentas.Rows.Add(fila);
                }
            } catch
            {
                throw new Exception("Error al cargar ventas");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaVenta frmAltaVenta = new frmAltaVenta(idUsuario);
            frmAltaVenta.ShowDialog();
            llenaDataGridVentas();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea marcar esta venta como devuelta?", "Confirmar devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<bool> devolucionCorrecta = new List<bool>();
                    // loop para permitir devolver varias ventas a la vez
                    foreach (DataGridViewRow filaSeleccionada in dgvVentas.SelectedRows)
                    {
                        Guid idVenta = (Guid)filaSeleccionada.Cells["id"].Value;
                        bool devolucionCorrectaDeFila = ventaN.EliminarVenta(idVenta, idUsuario);

                        devolucionCorrecta.Add(devolucionCorrectaDeFila);

                        // que salga del loop si hay alguna creacion incorrecta.
                        if (!devolucionCorrectaDeFila) break;
                    }

                    if (devolucionCorrecta.All((resultado) => resultado == true))
                    {
                        MessageBox.Show("Devolución de venta exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("Existen errores para la devolución de la venta.");
                        return;
                    }
                    try
                    {
                        dgvVentas.SuspendLayout();
                        dgvVentas.Rows.Clear();
                        llenaDataGridVentas();
                        dgvVentas.ResumeLayout();
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un error al refrescar la lista de ventas.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila de la grilla para registrar su devolución.");
            }
        }
    }
}
