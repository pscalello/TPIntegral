using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InterfazForm.Ventas
{

    public partial class frmAltaVenta : Form
    {
        public static string nombreCliente { get; set; }

        public static Guid idCliente { get; set; }

        public static bool esClienteNuevo { get; set; }

        public static Guid idProducto { get; set; }

        public static string nombreProducto { get; set; }

        public static int cantidadProducto { get; set; }

        public static float precioProducto { get; set; }

        public static int stockProducto { get; set; }

        public static int idCategoria { get; set; }

        public static bool agregaRenglon = false;

        public Guid idUsuario { get; set; }
        private ProductosN productoN = new ProductosN();
        private string acumuladorProductoBajoStock = "";

        public frmAltaVenta(Guid idUsuario)
        {
            this.idUsuario = idUsuario;
            InitializeComponent();
        }

        private void frmAltaVenta_Load(object sender, EventArgs e)
        {

            // Agregar las columnas al DataGridView

            dgvVenta.Columns.Add("IDProducto", "ID Producto");
            dgvVenta.Columns.Add("Descripcion", "Descripcion");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("MontoUnitario", "Monto Unitario");
            dgvVenta.Columns.Add("MontoTotal", "Monto Total Previo A Descuento");
            dgvVenta.Columns.Add("IdCategoria", "idcategoria");

            dgvVenta.Columns[5].Visible = false;

            // Formato Columnas
            dgvVenta.Columns["Cantidad"].DefaultCellStyle.Format = "N0";      // N0 para formato numérico sin decimales y con separador de miles
            dgvVenta.Columns["MontoUnitario"].DefaultCellStyle.Format = "N2"; // N para formato numérico sin separador de miles ni decimales
            dgvVenta.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";   // N2 para formato numérico con dos decimales y separador de miles
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void llenaDataGriedProductos()
        {
            object[] fila1 = { idProducto, nombreProducto, cantidadProducto, precioProducto, cantidadProducto * precioProducto, idCategoria };
            dgvVenta.Rows.Add(fila1);
            CalcularMontoAutom();

        }


        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente frmConsultarCliente = new frmConsultarCliente();
            frmConsultarCliente.ShowDialog();
            CalcularMontoAutom();
        }

        private void frmAltaVenta_Activated(object sender, EventArgs e) //refresca el datagrid
        {
            txtCliente.Text = nombreCliente;
            if (agregaRenglon == true)
            {
                bool existeProducto = false;

                foreach (DataGridViewRow renglon in dgvVenta.Rows)
                {
                    if (dgvVenta.RowCount == 0)
                    {
                        existeProducto = false;
                        break;
                    }
                    else if (Guid.Parse(renglon.Cells[0].Value.ToString()) == idProducto)
                    {
                        existeProducto = true;
                        MessageBox.Show("Este producto ya fue agregado. Elimínelo y vuelva a agregarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                }
                if (existeProducto == false)
                {
                    llenaDataGriedProductos();

                }

                agregaRenglon = false;

            }

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                frmConsultarProducto frmConsultarProducto = new frmConsultarProducto(idUsuario);
                frmConsultarProducto.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe seleccionar un cliente para agregar productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvVenta.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow filaSeleccionada in dgvVenta.SelectedRows)
                        {
                            dgvVenta.Rows.Remove(filaSeleccionada);
                        }
                        CalcularMontoAutom();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos una fila de la grilla a eliminar.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila de la grilla a eliminar.");
            }

        }

        private void CalcularMontoAutom()
        {
            decimal suma = 0;
            decimal sumaElectroHogar = 0;
            decimal descuentoelectro = 0;
            decimal descuentocliente = 0;
            decimal montofinal = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {

                if (fila.Cells["MontoTotal"].Value != null && decimal.TryParse(fila.Cells["MontoTotal"].Value.ToString(), out decimal valor))
                {
                    suma = suma + valor;

                    if (fila.Cells["IdCategoria"].Value != null && int.TryParse(fila.Cells["IdCategoria"].Value.ToString(), out int categoria))
                    {
                        if (categoria == 3)
                        {
                            sumaElectroHogar = sumaElectroHogar + valor;
                        }

                    }
                }
            }

            if (sumaElectroHogar > 100000)
            {
                descuentoelectro = sumaElectroHogar * 0.05m;
            }

            if (esClienteNuevo)
            {
                descuentocliente = (suma - descuentoelectro) * 0.05m;
            }
            
            montofinal = suma - descuentoelectro - descuentocliente;

            txtMontoTotal.Text = suma.ToString("N2", new CultureInfo("es-ES"));
            txtPromoElectroHogar.Text = descuentoelectro.ToString("N2", new CultureInfo("es-ES"));
            txtPromoClienteNuevo.Text = descuentocliente.ToString("N2", new CultureInfo("es-ES"));
            txtMontoFinal.Text = montofinal.ToString("N2", new CultureInfo("es-ES"));
        }


        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            VentaN ventaNueva = new VentaN();
            List<bool> creacionCorrecta = new List<bool>();

            if (dgvVenta.Rows.Count > 0 && txtMontoFinal.Text.Length != 0)
            {
                foreach (DataGridViewRow fila in dgvVenta.Rows)
                {
                    Guid guidIdProducto = Guid.Parse(fila?.Cells["IDProducto"]?.Value?.ToString());
                    int cantidadParseada = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                    bool creacionCorrectaDeFila = ventaNueva.AgregarVenta(idCliente, idUsuario, guidIdProducto, cantidadParseada);

                    creacionCorrecta.Add(creacionCorrectaDeFila);

                    // que salga del loop si hay alguna creacion incorrecta.
                    if (!creacionCorrectaDeFila) break;
                }

                // si la creacion fue correcta para todas las filas
                if (creacionCorrecta.All((resultado) => resultado == true))
                {
                    MessageBox.Show("Creación de venta exitosa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existen errores para la creación de la venta.");
                }
            }
            else if (dgvVenta.Rows.Count == 0)
            { // si no agregó ningún producto.
                MessageBox.Show("Debe ingresar un cliente y al menos un producto para confirmar la venta.");
                return;
            }
            else
            { // si no calculó el monto final.
                MessageBox.Show("Presione el botón \"Calcular Monto\" para conocer el monto final con descuento.");
                return;
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
