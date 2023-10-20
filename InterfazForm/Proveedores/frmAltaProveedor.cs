using Entidad;
using InterfazForm.Utils;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForm.Proveedores
{
    public partial class frmAltaProveedor : Form
    {
        private ProveedorN proveedorN = new ProveedorN();
        public frmAltaProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion())
            {
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                string cuit = this.txtCUIT.Text;
                string email = this.txtEmail.Text;

                bool creacionCorrecta = proveedorN.AgregarProveedor(nombre, apellido, cuit, email);

                if (creacionCorrecta)
                {
                    MessageBox.Show("Creación de usuario exitosa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existen errores para la creación del proveedor.");
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
            else if (!Validador.ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("El mail ingresado no tiene formato de mail.");
                txtEmail.Focus();
                return false;
            }
            else if (!Validador.ValidaNumeroLargo(txtCUIT.Text, 1000000000, 99999999999))
            {
                MessageBox.Show("El CUIT sólo debe contener números entre 1000000000 y 99999999999.");
                txtCUIT.Focus();
                return false;
            }
            return true;
        }

    }
}

