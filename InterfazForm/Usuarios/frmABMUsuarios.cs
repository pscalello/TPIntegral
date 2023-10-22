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

namespace InterfazForm.Usuarios
{
    public partial class frmABMUsuarios : Form
    {
        private UsuarioN usuarioN = new UsuarioN();

        public frmABMUsuarios()
        {
            InitializeComponent();
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            llenaDataGriedUsuarios();
        }

        private void llenaDataGriedUsuarios()
        {
            List<RespuestaConsultaUsuarios> listaUsuarios = usuarioN.listaUsuarios();
            dgvUsuarios.SuspendLayout(); // reduce el parpadeo al dibujar el control. Al final se vuelve a activar
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvUsuarios.Columns[0].Visible = false; // Oculto id
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["apellido"].HeaderText = "Apellido";
            dgvUsuarios.Columns["dni"].HeaderText = "DNI";
            dgvUsuarios.Columns["host"].HeaderText = "Perfil";
            dgvUsuarios.Columns["nombreUsuario"].HeaderText = "Usuario";
            dgvUsuarios.ResumeLayout();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltaUsuario = new frmAltaUsuario();
            frmAltaUsuario.ShowDialog();
            llenaDataGriedUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0]; //captura id que está oculta
                                                                                    //MessageBox.Show(filaSeleccionada.Cells[0].Value.ToString());
                    Guid guid = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());


                    bool eliminaUsuario = usuarioN.EliminarUsuario(guid);
                    if (eliminaUsuario)
                    {
                        llenaDataGriedUsuarios();
                        MessageBox.Show("Usuario eliminado correctamente.");
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
    }
}
