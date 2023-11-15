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

            

            if (tipoReporte ==1)
            {

                this.Text = "Reporte de stock crítico";
                this.lblNombreReporte.Text = "Reporte de stock crítico";
                
                
                ProductosN productoN = new ProductosN();
                List<RespuestaConsultaProducto> listaProductos = productoN.listaProductos();
                dgvReporte.DataSource = listaProductos;

                dgvReporte.Columns[0].Visible = false; // Columna 0
                dgvReporte.Columns[1].Visible = false; // Columna 1
                dgvReporte.Columns[2].Visible = false; // Columna 2
                dgvReporte.Columns[3].Visible = false; // Columna 3
                dgvReporte.Columns[5].Visible = false; // Columna 5

                
            }

            


        }


        private void AparienciaDatagriedReporte ()
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


    }
}
