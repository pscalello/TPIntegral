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
using InterfazForm.Reportes;

namespace InterfazForm
{
    public partial class frmMenuPrincipal : Form
    {
        internal int Host;
        internal Guid idUsuario;
        private ProductosN productoN = new ProductosN();
        private Control controlTooltipActual = null;
        public frmMenuPrincipal(Guid idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            logoCarga.Visible = false;
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
            logoCarga.Visible = true;
            frmABMVentas frmABMVentas = new frmABMVentas(idUsuario, Host);
            frmABMVentas.ShowDialog();
            logoCarga.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmReportes = new frmReportes(Host);
            frmReportes.ShowDialog();
            //MessageBox.Show("Esta funcionalidad estará disponible en las próximas versiones del sistema.");
        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();
        }

        private void frmMenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = GetChildAtPoint(e.Location);
            if (control != null)
            {
                if (!control.Enabled && controlTooltipActual == null)
                {
                    string toolTipString = getTextoTooltip(control);
                    tooltipBotonesDeshabilitados.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                    controlTooltipActual = control;
                }
            }
            else
            {
                if (controlTooltipActual != null) tooltipBotonesDeshabilitados.Hide(controlTooltipActual);
                controlTooltipActual = null;
            }
        }

        private string getTextoTooltip(dynamic control)
        {
            if (control == btnVentas)
            {
                return "Esta funcionalidad solo está disponible para Vendedores y Supervisores";
            }
            else if (control == btnABMProductos)
            {
                return "Esta funcionalidad solo está disponible para Supervisores y Administradores";
            }
            else
            {
                return "Esta funcionalidad solo está disponible para Administradores";
            }
        }
    }
}
