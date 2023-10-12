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





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion())
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
                    MessageBox.Show("Existen errores para la creación del usuario. El nombre de\n" +
                                    "usuario debe tener entre 8 y 15 caracteres, y el mismo no\n" +
                                    "puede contener ni su nombre ni su apellido");
                }
            }
        }




        ////////////////////////////////////////////////////
        ///    VALIDACIONES  DE INTEGRACION DE DATOS    ///
        ///////////////////////////////////////////////////

        private bool validaVacios()
        {
            var textBoxes = this.Controls.OfType<System.Windows.Forms.TextBox>()
                                        .OrderBy(c => c.Top); // Ordena por la posición vertical (de arriba a abajo).

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.");
                    textBox.Focus();
                    return false; // Al encontrar un TextBox vacío, retorna false.
                }
            }

            return true; // Si todos los TextBox están llenos, retorna true.
        }

        private bool validaIntegracion()
        {
            if (!Validador.ValidaPalabra(txtNombre.Text, 3))
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres y contener solo letras.");
                txtNombre.Focus();
                return false;
            }
            else if (!Validador.ValidaPalabra(txtApellido.Text, 3))
            {
                MessageBox.Show("El apellido debe tener al menos 3 caracteres.");
                txtApellido.Focus();
                return false;
            }
            else if (!Validador.ValidaPalabra(txtDireccion.Text, 5))
            {
                MessageBox.Show("La dirección debe tener al menos 5 caracteres.");
                txtDireccion.Focus();
                return false;
            }
            else if (!Validador.ValidaPalabra(txtTelefono.Text, 7))
            {
                MessageBox.Show("El teléfono debe tener al menos 7 caracteres.");
                txtTelefono.Focus();
                return false;
            }
            else if (!Validador.ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("El mail ingresado no tiene formato de mail.");
                txtEmail.Focus();
                return false;
            }
            else if (!Validador.ValidaPalabra(txtNombreUsuario.Text, 8))
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 8 caracteres.");
                txtNombreUsuario.Focus();
                return false;
            }
            else if (!Validador.ValidaNumero(txtDNI.Text, 1000000, 99999999))
            {
                MessageBox.Show("El DNI sólo debe contener números entre 1000000 y 99999999.");
                txtDNI.Focus();
                return false;
            }
            return true;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            cboHost.SelectedIndex = 0;
        }
    }
}
