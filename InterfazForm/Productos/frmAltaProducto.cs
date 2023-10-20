using Entidad;
using InterfazForm.Utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfazForm.Proveedores
{
    public partial class frmAltaProducto : Form
    {
        private ProveedorN proveedorN = new ProveedorN();
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            List<RespuestaConsultaProveedores> listaProveedores = proveedorN.listaProveedores();
            cboCategoria.SelectedIndex = 0;
            foreach (var proveedor in listaProveedores)
            {
                cboProveedor.Items.Add(proveedor.nombre + " " + proveedor.apellido);
                cboGuidProveedor.Items.Add(proveedor.id);
            }
            cboProveedor.SelectedIndex = 0;
        }

        //DEJO COMO COMENTARIO PORQUE NO ANDA
        /*
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion())
            {
                ProductosN ProductoNuevo = new ProductosN();


                string nombre = txtNombre.Text;
                Guid idcategoria =
                //faltaria ver si la categoria es guid o int
                DateTime fechaAlta =


                //chequear
                double precio = Convert.ToDouble(txtPrecio);
                int stock = Convert.ToInt32(txtStock);


                bool creacionCorrecta = ProductosN.CrearProducto(id, idCategoria, nombre, fechaAlta, fechaBaja, precio, stock, idUsuario, idProveedor);

                if (creacionCorrecta)
                {
                    MessageBox.Show("Creación de producto exitosa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existen errores para la creación del producto");
                }
            }
        }

        */

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
                    MessageBox.Show("No puede haber campos vacíos.");
                    textBox.Focus();
                    return false; // Al encontrar un TextBox vacío, retorna false.
                }
            }

            return true; // Si todos los TextBox están llenos, retorna true.
        }

        private bool validaIntegracion()
        {
            if (!Validador.ValidaNombreProd(txtNombre.Text, 3))
            {
                MessageBox.Show("El nombre no puede tener menos de 3 caracteres.");
                txtNombre.Focus();
                return false;
            }
            else if (!double.TryParse(txtPrecio.Text, out double salidaPrecio))
            {
                MessageBox.Show("El precio debe ser numérico. Ej: 100.05");
                txtPrecio.Focus();
                return false;
            }
            else if (salidaPrecio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.");
                txtPrecio.Focus();
                return false;
            }
            else if (!int.TryParse(txtStock.Text, out int salidaStock))
            {
                MessageBox.Show("El stock debe ser numérico.");
                txtStock.Focus();
                return false;
            }
            else if (salidaStock < 0)
            {
                MessageBox.Show("El stock debe ser 0 o más.");
                txtStock.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGuidProveedor.SelectedIndex = cboProveedor.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaVacios() && validaIntegracion())
            {
                ProductosN ProductoNuevo = new ProductosN();

                int idCategoria = cboCategoria.SelectedIndex + 1;
                Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                Guid idProveedor = Guid.Parse(cboGuidProveedor.SelectedItem.ToString());
                string nombre = txtNombre.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);


                bool creacionCorrecta = ProductoNuevo.CrearProducto(idCategoria, idUsuario, idProveedor, nombre, precio, stock);

                if (creacionCorrecta)
                {
                    MessageBox.Show("Creación de producto exitosa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existen errores para la creación del producto");
                }
            }
        }
    }

}
