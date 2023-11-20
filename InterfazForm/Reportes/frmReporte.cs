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
using Negocio;

namespace InterfazForm.Reportes
{
    public partial class frmReporte : Form
    {
        private int tipoReporte;

        public frmReporte(int tipoReporte)
        {
            InitializeComponent();
            this.tipoReporte = tipoReporte;
        }


        private void frmReporte_Load(object sender, EventArgs e)
        {
            CompletaReporte();
        }


        private void CompletaReporte()
        {
            AparienciaDatagriedReporte();



            if (tipoReporte == 1)
            {
                this.Text = "Reporte de stock crítico";
                this.lblNombreReporte.Text = "Reporte de stock crítico";

                // No está el swagger de ventas preparado para información para este reporte
                // El objetivo en este TP es solo mostrar el diseño del reporte
                // Se completa con una lista de productos y cantidades para este fin.

                ProductosN productoN = new ProductosN();
                List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();
                dgvReporte.DataSource = listaProductos;

                dgvReporte.Columns[0].Visible = false; // Columna 0
                dgvReporte.Columns[1].Visible = false; // Columna 1
                dgvReporte.Columns[2].Visible = false; // Columna 2
                dgvReporte.Columns[3].Visible = false; // Columna 3
                dgvReporte.Columns[5].Visible = false; // Columna 5

                // Establecer el ancho automático para todas las columnas
                foreach (DataGridViewColumn column in dgvReporte.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

            }

            if (tipoReporte == 2)
            {
                this.Text = "Reporte de ventas por vendedor";
                this.lblNombreReporte.Text = "Reporte de ventas por vendedor";

                // No está el swagger de ventas preparado para información para este reporte
                // El objetivo en este TP es solo mostrar el diseño del reporte
                // Se completa con una lista de vendedores y un importe de ventas aleatorio.

                UsuarioN usuarioN = new UsuarioN();
                List<RespuestaConsultaUsuarios> ConsultaVendedores = usuarioN.listaVendedores();

                dgvReporte.DataSource = ConsultaVendedores;

                // Oculto columnas 0 (id), 3 (dni), 4 (nombre de usuario) y 5 (host)
                dgvReporte.Columns[0].Visible = false;
                dgvReporte.Columns[3].Visible = false;
                dgvReporte.Columns[4].Visible = false;
                dgvReporte.Columns[5].Visible = false;

                // Renombro columnas 1 y 2 para que tenga primera letra en mayúscula
                dgvReporte.Columns[1].HeaderText = "Nombre";
                dgvReporte.Columns[2].HeaderText = "Apellido";


                // Agrego la nueva columna para simular un monto de ventas y que la alineación sea derecha
                dgvReporte.Columns.Add("Ventas", "Ventas");
                dgvReporte.Columns["Ventas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Genero y asigno valores aleatorios a la columna "Ventas"
                Random random = new Random();
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    int valorAleatorio = random.Next(10000, 1000001);
                    row.Cells["Ventas"].Value = valorAleatorio;
                }

                // Establecer el ancho automático para todas las columnas
                foreach (DataGridViewColumn column in dgvReporte.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

            }


            if (tipoReporte == 3)
            {
                this.Text = "Reporte de productos más vendidos por categoría";
                this.lblNombreReporte.Text = "Reporte de productos más vendidos por categoría";


                ProductosN productoN = new ProductosN();
                List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();
                //dgvReporte.DataSource = listaProductos;

                dgvReporte.Columns.Add("Categoria", "Categoría");
                dgvReporte.Columns.Add("Nombre", "Nombre");
                dgvReporte.Columns.Add("Ventas", "Ventas");
                // Alinea ventas a la derecha
                dgvReporte.Columns["Ventas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                foreach (RespuestaConsultaProducto producto in listaProductos)
                {
                    string categoria = "";
                    switch (producto.idCategoria)
                    {
                        case 1:
                            categoria = "Audio";
                            break;
                        case 2:
                            categoria = "Celulares";
                            break;
                        case 3:
                            categoria = "Electro Hogar";
                            break;
                        case 4:
                            categoria = "Informática";
                            break;
                        case 5:
                            categoria = "Smart TV";
                            break;
                            // ... agregar más casos según sea necesario ...
                    }
                    int ventasAleatorias = new Random().Next(10000, 1000001);
                    dgvReporte.Rows.Add(categoria, producto.nombre, ventasAleatorias);
                }

                // Ordenar por columna 3 y luego 1
                dgvReporte.Sort(dgvReporte.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
                dgvReporte.Sort(dgvReporte.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                // Deshabilitar la ordenación para todas las columnas
                foreach (DataGridViewColumn column in dgvReporte.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // Establecer el ancho automático para todas las columnas
                foreach (DataGridViewColumn column in dgvReporte.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }



        }


        private void AparienciaDatagriedReporte()
        {
            // Este método intenta que un datagried parezca un pdf a imprimir
            // se puede mejorar, es general para todos los reportes, los 3
            // tipos de reportes lo llaman. Ventaja Datagried: se pasa source y
            // se completa

            // Configuración de apariencia para el DataGridView
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvReporte.DefaultCellStyle.BackColor = Color.White;
            dgvReporte.DefaultCellStyle.ForeColor = Color.Black;
            dgvReporte.DefaultCellStyle.SelectionBackColor = Color.White; // Evitar que se vea seleccionado
            dgvReporte.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AllowUserToResizeRows = false;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // Fondo blanco para los encabezados
            dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font(dgvReporte.Font, FontStyle.Bold);
            dgvReporte.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReporte.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White; // Evitar cambio de color al seleccionar
            dgvReporte.EnableHeadersVisualStyles = false;

            // Desactivar la selección de celdas
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.MultiSelect = false;

            // Oculta las líneas divisorias de las cabeceras
            dgvReporte.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad estará habilitada en futuras versiones");
        }

        private void brtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
