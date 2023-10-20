using Datos;
using Entidad;
using Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Proveedores
{
    public partial class frmABMProveedores : Form
    {

        private ProveedorN proveedorN = new ProveedorN();

        public frmABMProveedores()
        {
            InitializeComponent();
        }

        private void frmABMProveedores_Load(object sender, EventArgs e)
        {
            llenaDataGridProveedores();
        }

        private void llenaDataGridProveedores()
        {
            List<RespuestaConsultaProveedores> listaProveedores = proveedorN.listaProveedores();
            dgvProveedores.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProveedores.Columns[0].Visible = false; // Oculto id
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Columns["nombre"].HeaderText = "Nombre";
            dgvProveedores.Columns["apellido"].HeaderText = "Apellido";
            dgvProveedores.Columns["email"].HeaderText = "Email";
            dgvProveedores.Columns["cuit"].HeaderText = "CUIT";
            dgvProveedores.Columns["fechaAlta"].HeaderText = "Fecha Alta";
            dgvProveedores.ResumeLayout();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvProveedores.SelectedRows[0]; //captura id que está oculta
                                                                                       //MessageBox.Show(filaSeleccionada.Cells[0].Value.ToString());
                    Guid guid = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());


                    bool eliminaProveedor = proveedorN.EliminarProveedor(guid);
                    if (eliminaProveedor)
                    {
                        llenaDataGridProveedores();
                        MessageBox.Show("Proveedor eliminado correctamente.");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProveedor frmAltaProveedor = new frmAltaProveedor();
            frmAltaProveedor.ShowDialog();
        }
    }
}
