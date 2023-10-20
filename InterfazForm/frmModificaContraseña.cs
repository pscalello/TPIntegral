using Entidad;
using Negocio;
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
    public partial class frmModificaContraseña : Form
    {
        private LoginE login;
        public frmModificaContraseña(LoginE login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioN usuarioN = new UsuarioN();
            bool cambioExitoso = usuarioN.CambioContraseña(login.NombreUsuario, login.Contraseña, this.txtNuevaContraseña.Text);
            if (cambioExitoso)
            {
                MessageBox.Show("Su contraseña ha sido modificada de forma exitosa. Por favor vuelva a ingresar con su nueva contraseña.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede usar esa contraseña. La contraseña debe ser de entre 8 y 15 carácteres, " +
                    "con una mayúscula y un número, distinta a la que recibió para el primer logueo.");
                this.txtNuevaContraseña.Clear();
            }
        }
    }
}
