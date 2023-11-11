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
using InterfazForm.Utils;
using Negocio;

namespace InterfazForm.Clientes
{
    public partial class frmModificacionCliente : Form
    {
        private RespuestaConsultaCliente clienteAModificar;
        public frmModificacionCliente(RespuestaConsultaCliente clienteAModificar)
        {
            InitializeComponent();
            this.clienteAModificar = clienteAModificar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion())
            {
                ClienteN clienteNuevo = new ClienteN();

                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;

                bool modificacionCorrecta = false; // hacer llamado de modificacion en ClienteN y ClienteD

                if (modificacionCorrecta)
                {
                    MessageBox.Show("Modificación de cliente exitosa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existen errores para la modificación del cliente.");
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
            if (!Validador.ValidaPalabraConCaracteresEspeciales(txtDireccion.Text, 5))
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
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = clienteAModificar.nombre;
            txtApellido.Text = clienteAModificar.apellido;
            txtDNI.Text = clienteAModificar.dni.ToString();
            txtEmail.Text = clienteAModificar.email;
            txtDireccion.Text = clienteAModificar.direccion;
            txtTelefono.Text = clienteAModificar.telefono;
        }
    }
}
