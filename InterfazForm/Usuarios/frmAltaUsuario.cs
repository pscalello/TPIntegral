using InterfazForm.Utils;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaVacios())
            {
                UsuarioN UsuarioNuevo = new UsuarioN();

                int host = cboHost.SelectedIndex + 1;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = int.Parse(txtDNI.Text);
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                DateTime fechaNacimiento = dtiFechaNacimiento.Value;
                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = "CAI20232";

                bool creacionCorrecta = UsuarioNuevo.CrearUsuario(host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario);
                if (creacionCorrecta)
                {
                    MessageBox.Show("Creación de usuario exitosa!");
                    this.Close(); 

                }
                else
                {
                    MessageBox.Show("Existen errores para la creación. Recuerde \n " +
                                    "que el nombre de usuario debe tener entre 8\n" +
                                    "y 15 carateres, y que el mismo no puede contener \n"+
                                    "ni su nombre ni su apellido");
                }
            }
        }

        private bool validaVacios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("El campo no puede estar vacío.");
                        textBox.Focus();
                        return false; // Al encontrar un TextBox vacío, retorna false.
                    }
                }
            }

            return true; // Si todos los TextBox están llenos, retorna true.
        }
    }
}
