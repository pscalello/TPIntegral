using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm
{
    public partial class frmMenuPrincipal : Form
    {
        internal int Host;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            switch (Host)
            {
                case 1: // Vendedor
                    btnABMUsuarios.Enabled = false;
                    btnABMProveedores.Enabled = false;
                    btnABMProductos.Enabled = false;
                    btnDevoluciones.Enabled = false;
                    break;
                case 2: //Supervisor
                    btnABMUsuarios.Enabled = false;
                    btnABMProveedores.Enabled = false;
                    btnVentas.Enabled = false;
                    break;
                case 3: //Administrador
                    btnVentas.Enabled = false;
                    btnDevoluciones.Enabled = false;
                    break;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
