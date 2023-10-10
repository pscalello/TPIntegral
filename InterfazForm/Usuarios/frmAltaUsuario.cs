using InterfazForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Usuarios
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }



        ////////////////////////////////////////////////////
        ///    VALIDACIONES  DE INTEGRACION DE DATOS    ///
        ///////////////////////////////////////////////////


        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string input = txtNombre.Text.Trim();
            if (!Validador.ValidaPalabra(input, 3))
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres y contener solo letras.");
                e.Cancel = true;
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            string input = txtApellido.Text.Trim();
            if (!Validador.ValidaPalabra(input, 3))
            {
                MessageBox.Show("El apellido debe tener al menos 3 caracteres.");
                e.Cancel = true;
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            string input = txtDireccion.Text.Trim();
            if (!Validador.ValidaPalabra(input, 5))
            {
                MessageBox.Show("La dirección debe tener al menos 5 caracteres.");
                e.Cancel = true;
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTelefono.Text.Trim();
            if (!Validador.ValidaPalabra(input, 7))
            {
                MessageBox.Show("El teléfono debe tener al menos 7 caracteres.");
                e.Cancel = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string input = txtEmail.Text.Trim();
            if (!Validador.ValidaEmail(input))
            {
                MessageBox.Show("El mail ingresado no tiene formato de mail.");
                e.Cancel = true;
            }
        }

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            string input = txtNombreUsuario.Text.Trim();
            if (!Validador.ValidaPalabra(input, 8))
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 8 caracteres.");
                e.Cancel = true;
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            string input = txtDNI.Text.Trim();
            if (!Validador.ValidaNumero(input))
            {
                MessageBox.Show("El DNI sólo debe contener números.");
                e.Cancel = true;
            }
        }
    }
}
