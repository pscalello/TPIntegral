using System.Drawing;

namespace InterfazForm
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            //this.Hide();    
            frmLogin.Show();

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TP INTEGRAL CAI 2 - LOGIN \n" +
                        "Esta opción de Auto Registro estará disponible en versiones posteriores para clientes. \n" +
                        "Sólo se pueden registrar Supervisores y Vendedores mediante el login de un Administrador.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
      
    }
}