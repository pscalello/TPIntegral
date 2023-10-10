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
using Datos;

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
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            intentos = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // validar consistencia
            string respuestas;


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
                frmModificaContraseña frmModificaContraseña = new frmModificaContraseña();
                frmModificaContraseña.Show();
                this.Close();
            }
            else // Loquego ok, tenemos el ID del usuario logueado
            {
                Guid guid = new Guid(respuesta.Replace("\"", "")); //Viene con comillas la respuesta - reemplazo y parsea a GUID


                ///////////////////////////////////////////////////////
                // Está FALLANDO ESTE METODO buscarHost
                ///////////////////////////////////////////////////////

                //int hostUsuario =  UsuarioLogueadoN.BuscarHostUsuario(guid);

                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();


                ///////////////////////////////////////////////////////
                // Está trayendo TODOS los host en cero, revisar - Paso 3 para pasar a ver las altas
                ///////////////////////////////////////////////////////


                //frmMenuPrincipal.Host = hostUsuario;
                frmMenuPrincipal.Host = 3;

                frmMenuPrincipal.Show();


                this.Close();

                // 3 es Admin, 2 es Supervisor, 1 es Vendedor

            }




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
