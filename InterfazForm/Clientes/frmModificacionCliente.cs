using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;
using InterfazForm.Utils;
using Negocio;

namespace InterfazForm.Clientes
{
    public partial class frmModificacionCliente : Form
    {
        private RespuestaConsultaCliente clienteAModificar;
        private ClienteN clienteN;
        public frmModificacionCliente(RespuestaConsultaCliente clienteAModificar)
        {
            InitializeComponent();
            this.clienteAModificar = clienteAModificar;
            this.clienteN = new ClienteN();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion() && validaModificado())
            {
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                string estado = ddEstado.Text;

                if (estado == "Activo")
                {
                    bool modificacionCorrecta = clienteN.ModificarCliente(clienteAModificar.id, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);

                    if (modificacionCorrecta)
                    {
                        MessageBox.Show("¡Modificación de cliente exitosa!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Existen errores para la modificación del cliente, por favor vuelva a intentarlo.");
                    }
                } else // estado == "Inactivo"
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea inactivar este cliente?", "Confirmar inactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if ( // si hay alguna modificación además de la inactivación.
                            clienteAModificar.direccion != txtDireccion.Text ||
                            clienteAModificar.telefono != txtTelefono.Text ||
                            clienteAModificar.email != txtEmail.Text
                        )
                        {
                            bool modificacionCorrecta = clienteN.ModificarCliente(clienteAModificar.id, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);

                            if (modificacionCorrecta)
                            {
                                MessageBox.Show("¡Modificación de cliente exitosa! Cierre este mensaje para seguir con la inactivación del mismo.");
                            }
                            else
                            {
                                MessageBox.Show("Existen errores para la modificación del cliente, por favor vuelva a intentarlo.");
                                return;
                            }
                        }

                        // inactiva el cliente
                        bool eliminaCliente = clienteN.EliminarClientes(clienteAModificar.id);

                        if (eliminaCliente)
                        {
                            MessageBox.Show("Cliente inactivado correctamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Falló la inactivación, por favor vuelva a intentarlo");
                        }

                    }
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

        private bool validaModificado()
        {
            // valida que haya alguna modificacion, que no sean los mismos datos que ya tiene guardados el cliente.
            if (
                clienteAModificar.direccion != txtDireccion.Text ||
                clienteAModificar.telefono != txtTelefono.Text ||
                clienteAModificar.email != txtEmail.Text ||
                clienteAModificar.estado != ddEstado.Text
            )
            {
                return true;
            } else
            {
                MessageBox.Show("Los datos ingresados no presentan ninguna modificación.");
                return false;
            }
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

            ddEstado.DataSource = new string[]
            {
                "Activo",
                "Inactivo"
            };
        }
    }
}
