using InterfazForm.Usuarios;
using InterfazForm.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazForm;
using InterfazForm.Productos;
using System.Reflection.Emit;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entidad;
using InterfazForm.Clientes;
using InterfazForm.Ventas;

namespace InterfazForm
{
    public partial class frmMenuPrincipal : Form
    {
        internal int Host;
        internal Guid idUsuario;
        private ProductosN productoN = new ProductosN();
        public frmMenuPrincipal(Guid idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();

            if (Host == 3 || Host == 2)
            {
                //if (condicion de stock){
                lblAlertaStock.Visible = true;
                string acumuladorProductoBajoStock = "";
                foreach (var productoBajoStock in listaProductos)
                {
                    if (productoBajoStock != null)
                    {
                        acumuladorProductoBajoStock += productoBajoStock.nombre + "\n";
                    }
                }

                tlDesplegableProductos.SetToolTip(lblAlertaStock, "Acá irian los productos que estén por debajo del 25% del stock designado, por ahora trae \ntodos los productos. Falta la condición que indique cuál es el 25% del stock.\n" + acumuladorProductoBajoStock);
                /*
                }
                else
                {
                    lblAlertaStock.Visible = false;
                }
                */
            }
            else
            {
                lblAlertaStock.Visible = false;
            }


            switch (Host)
            {
                case 3: // Administrador
                    btnABMUsuarios.Enabled = true;
                    btnABMProveedores.Enabled = true;
                    btnABMProductos.Enabled = true;
                    btnVentas.Enabled = false;
                    btnReportes.Enabled = true;
                    break;
                case 2: //Supervisor
                    btnABMUsuarios.Enabled = false;
                    btnABMProveedores.Enabled = false;
                    btnABMProductos.Enabled = true;
                    btnVentas.Enabled = true;
                    btnReportes.Enabled = true;
                    break;
                case 1: // Vendedor
                    btnABMUsuarios.Enabled = false;
                    btnABMProveedores.Enabled = false;
                    btnABMProductos.Enabled = false;
                    btnVentas.Enabled = true;
                    btnReportes.Enabled = true;
                    break;


            }
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {
            frmABMUsuarios frmABMUsuarios = new frmABMUsuarios();
            frmABMUsuarios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMProveedores_Click(object sender, EventArgs e)
        {
            frmABMProveedores frmABMProveedores = new frmABMProveedores();
            frmABMProveedores.ShowDialog();
        }

        private void btnABMProductos_Click(object sender, EventArgs e)
        {
            frmABMProductos frmABMProductos = new frmABMProductos();
            frmABMProductos.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmABMVentas frmABMVentas = new frmABMVentas(idUsuario, Host);
            frmABMVentas.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad estará disponible en las próximas versiones del sistema.");
        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();
        }
    }
}
