﻿using InterfazForm.Usuarios;
using InterfazForm.Proveedores;
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
                case 1: // Administrador
                    btnVentas.Enabled = false;
                    btnDevoluciones.Enabled = false;
                    break;
                case 2: //Supervisor
                    btnABMUsuarios.Enabled = true;
                    btnABMProveedores.Enabled = true;
                    btnVentas.Enabled = false;
                    break;
                case 3: // Vendedor
                    btnABMUsuarios.Enabled = true;
                    btnABMProveedores.Enabled = true;
                    btnABMProductos.Enabled = true;
                    btnDevoluciones.Enabled = false;
                    break;

            }
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {
            frmABMUsuarios frmABMUsuarios = new frmABMUsuarios();
            frmABMUsuarios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMProveedores_Click(object sender, EventArgs e)
        {
            frmABMProveedores frmABMProveedores = new frmABMProveedores();
            frmABMProveedores.ShowDialog();
        }
    }
}
