using Microsoft.VisualBasic.Logging;
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
using InterfazForm.Utils;



namespace InterfazForm
{
    public partial class frmLogin : Form
    {
        protected UsuarioN UsuarioLogueadoN = new UsuarioN();
        protected string IDUsuarioLogueado = "";
        private int intentos;

        public frmLogin()
        {
            InitializeComponent();
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            intentos = 0;
            txtContraseña.PasswordChar = '*';
            btnOcultarContraseña.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logoCarga.Image = Properties.Resources.icnLogoCarga;
            logoCarga.Visible = true;

            //string respuestas;


            LoginE login = new LoginE();
            login.NombreUsuario = this.txtUsuario.Text;
            login.Contraseña = this.txtContraseña.Text;


            string respuesta = UsuarioLogueadoN.Login(login);

            if (respuesta == "-1") // Si es -1, el password es malo
            {
                if (intentos == 2) // Si además de ser malo, fue su tercer intento, bloquear
                {
                    MessageBox.Show("Superó la cantidad de intentos. \n Comuníquese con un administrador para recuperar su contraseña");

                    // Falta desactivar usuario

                    this.Close();
                }
                else // Si no es su tercer intento, informar que los datos son incorrectos
                {
                    MessageBox.Show("Usuario o Password incorrecto, verifique los datos ingresados");
                    intentos++;
                }
            }
            else if (respuesta == "-2") // Si la respuesta es -2, es que pudo loguearse pero con pass genérico (CAI20232)
            {
                MessageBox.Show("Primer ingreso, por favor modifique su contraseña");
                frmModificaContraseña frmModificaContraseña = new frmModificaContraseña(login);
                frmModificaContraseña.Show();
                this.Close();
            }
            else // Loquego ok, tenemos el ID del usuario logueado
            {
                Guid idUsuario = new Guid(respuesta.Replace("\"", "")); //Viene con comillas la respuesta - reemplazo y parsea a GUID


                ///////////////////////////////////////////////////////
                // Está FALLANDO ESTE METODO buscarHost
                ///////////////////////////////////////////////////////

                int hostUsuario = UsuarioLogueadoN.BuscarHostUsuario(idUsuario);

                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(idUsuario);

                frmMenuPrincipal.Host = hostUsuario;
                frmMenuPrincipal.Show();
                this.Close();

            }

            txtUsuario.Text = "";
            txtContraseña.Text = "";
            logoCarga.Visible = false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            validacionActiva = false;
            this.Close();
        }


        ////////////////////////////////////////////////////
        ///    VALIDACIONES  DE INTEGRACION DE DATOS    ///
        ///////////////////////////////////////////////////
        private bool validacionActiva = false;

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (validacionActiva || btnSalir.Focused)
            {
                return; // Evita que la validación se ejecute nuevamente al cancelar el formulario
            }

            validacionActiva = true;

            string input = txtUsuario.Text.Trim();

            if (!Validador.ValidaPalabra(input, 3))
            {
                // La entrada no es válida, muestra un mensaje de error y cancela el evento.
                MessageBox.Show("El usuario debe tener al menos 3 caracteres y contener solo letras.");
                e.Cancel = true;

            }
            validacionActiva = false;

        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (validacionActiva || btnSalir.Focused)
            {
                return; // Evita que la validación se ejecute nuevamente al cancelar el formulario
            }

            validacionActiva = true;

            string input = txtContraseña.Text.Trim();

            if (!Validador.ValidaPalabra(input, 3))
            {
                // La entrada no es válida, muestra un mensaje de error y cancela el evento.
                MessageBox.Show("La contraseña debe tener al menos 3 caracteres y contener solo letras.");
                e.Cancel = true;
                validacionActiva = false;
            }
            
        }

        // que funcione el Enter como click, con el boton ingresar
        private void btnIngresar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '\0';
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {

            txtContraseña.PasswordChar = '*';
            btnOcultarContraseña.Visible = false;
            btnMostrarContraseña.Visible = true;
        }

        /*
        private void IniciarLogoCarga()
        {
            // Muestra el icono de carga
            
            logoCarga.Visible = true;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender, e) =>
            {
                btnIngresar_Click(sender,e);

            };
            worker.RunWorkerCompleted += (sender, e) =>
            {
                // Oculta el icono de carga después de que el proceso termina
                logoCarga.Visible = false;
            };
            worker.RunWorkerAsync();
        }
        */

    }
}
