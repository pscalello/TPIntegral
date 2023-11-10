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
    public partial class frmConsultarCliente : Form
    {
        private ClienteN clienteN = new ClienteN();
        public frmConsultarCliente()
        {
            InitializeComponent();

        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            llenaDataGriedClientes();
        }

        private void llenaDataGriedClientes()
        {
            List<RespuestaConsultaCliente> listaClientes = clienteN.listaClientes();
            dgvClientes.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
            dgvClientes.Columns[0].Visible = false; // Oculto id
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["dni"].HeaderText = "DNI";
            dgvClientes.Columns["direccion"].HeaderText = "Dirección";
            dgvClientes.Columns["telefono"].HeaderText = "Teléfono";
            dgvClientes.Columns["email"].HeaderText = "Email";
            dgvClientes.Columns["fechaNacimiento"].HeaderText = "Fecha de nacimiento";
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.ResumeLayout();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DatosCliente();
            this.Close();
        }

        private void DatosCliente()
        {
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
            frmAltaVenta.nombreCliente = filaSeleccionada.Cells[1].Value.ToString() + " " + filaSeleccionada.Cells[2].Value.ToString();
            frmAltaVenta.idCliente = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            DatosCliente();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
