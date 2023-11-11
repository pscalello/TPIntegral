using Datos;
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

namespace InterfazForm.Clientes
{
    public partial class frmABMClientes : Form
    {
        private ClienteN clienteN = new ClienteN();

        public frmABMClientes()
        {
            InitializeComponent();
        }

        private void frmABMClientes_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCliente frmAltaCliente = new frmAltaCliente();
            frmAltaCliente.ShowDialog();
            llenaDataGriedClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0]; //captura id que está oculta
                                                                                    //MessageBox.Show(filaSeleccionada.Cells[0].Value.ToString());
                    Guid guid = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    //MessageBox.Show(guid);


                    bool eliminaCliente = clienteN.EliminarClientes(guid);
                    if (eliminaCliente)
                    {
                        llenaDataGriedClientes();
                        MessageBox.Show("Cliente eliminado correctamente.");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo una fila de la grilla para modificar.");
            } else if (dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow cliente = dgvClientes.SelectedRows[0];
                RespuestaConsultaCliente clienteSeleccionado = new RespuestaConsultaCliente(
                    (Guid)cliente.Cells["id"].Value,
                    (string)cliente.Cells["nombre"].Value,
                    (string)cliente.Cells["apellido"].Value,
                    (int)cliente.Cells["dni"].Value,
                    (string)cliente.Cells["direccion"].Value,
                    (string)cliente.Cells["telefono"].Value,
                    (string)cliente.Cells["email"].Value,
                    (DateTime)cliente.Cells["fechaNacimiento"].Value,
                    (DateTime)cliente.Cells["fechaAlta"].Value,
                    cliente.Cells["fechaBaja"].Value != null ? (DateTime)cliente.Cells["fechaBaja"].Value : null,
                    (string)cliente.Cells["host"].Value
                   );
                frmModificacionCliente frmModificacionCliente = new frmModificacionCliente(clienteSeleccionado);
                frmModificacionCliente.ShowDialog();
                llenaDataGriedClientes();
            } else
            { // ninguna fila seleccionada
                MessageBox.Show("Debe seleccionar una fila de la grilla a modificar.");
            }
        }
    }
}
