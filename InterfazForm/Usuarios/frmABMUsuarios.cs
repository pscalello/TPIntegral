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
        private UsuarioN UsuarioLogueadoN = new UsuarioN();

        public frmABMUsuarios()
        {
            InitializeComponent();
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = UsuarioLogueadoN.listaUsuarios();
            dgvUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltaUsuario = new frmAltaUsuario();
            frmAltaUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
